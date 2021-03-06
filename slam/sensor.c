#include "sensor.h"

const static int poll_time = 100000;


static tPort *port;
static int **buffer;
static raw_sensor_scan lidar_data;
static raw_sensor_scan n_scans[MAX_SCANS];
static int last_poll, n;

pthread_t sensor_init_thread () {
  pthread_t t;
  pthread_create(&t, NULL, sensor_init, NULL);
  return t;
}

void* sensor_init(void *null_pointer) {
  port = scipConnect("/dev/ttyACM0");

  if (port == NULL) {
    perror("Could not connect to the sensor ");
    exit(EXIT_FAILURE);
  }

  // use SCIP2.0
  switchToScip2(port);
  if(scip2SetComSpeed(port,115200)!=0){
    fprintf(stderr,"Could not change speed\n");
    exit(EXIT_FAILURE);
  }

  last_poll = utime() - poll_time;
}


raw_sensor_scan sensor_read_raw() {
  // Initialize parameters for laser scanning
  int start_step = 44;
  int end_step = 725;
  int step_cluster = 1;
  int scan_interval = 0;
  int scan_num = 1;
  int step_num;

  int sleep_time = poll_time - (utime() - last_poll);
  if (sleep_time > 0)
    usleep(sleep_time);
  else printf("sleepless\n");

  buffer = scip2MeasureScan(port, start_step, end_step, step_cluster,
			    scan_interval, scan_num, ENC_3BYTE, &step_num);
  last_poll = utime();

  int i, distance;
  for (i = 0 ; i < step_num ; i++) {
    distance = buffer[0][i];
    if ((distance >= SENSOR_MIN) && (distance <= SENSOR_MAX))
      // Copy the data into the static variable
      lidar_data.distances[i] = distance;
  }
  return lidar_data;
}

void* sensor_read_raw_n(void *null_pointer) {
  int i;
  for (i = 0; i < n && i < MAX_SCANS; i++)
    n_scans[i] = sensor_read_raw();
}

pthread_t sensor_read_raw_n_thread(int requested_n) {
  pthread_t t;
  n = requested_n;
  assert(pthread_create(&t, NULL, sensor_read_raw_n, NULL) == 0);
  return t;
}

raw_sensor_scan sensor_fetch_index(int index) {
  return n_scans[index];
}

uint64_t utime() {
  struct timeval tv;
  gettimeofday(&tv, NULL);
  return tv.tv_sec*(uint64_t)1000000+tv.tv_usec;
}
