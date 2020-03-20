import time, smbus

bus = smbus.SMBus(1)
data = bus.read_i2c_block_data(0x61,0)
Co = data[0]
print (Co)
