from subprocess import Popen, PIPE
import os
import sys
import time
 
print("testing {0}...".format(sys.argv[1]));
for x in range(20):
  print("n = {0}".format(x))
  time.sleep(60)
