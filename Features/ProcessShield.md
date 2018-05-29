# Process Shield

**Description**

ProcessShield is a unique `(IntPtr)Handle` signature based process detection system. Each blacklisted process is given a signature and weight based on functionality. ProcessShield efficiently scans through all running process and compares signatures. 

`((weightFound \ sigWeight) * 100) > (.75f * sigWeight)`


![](http://tinyimg.io/i/r3xaHTe.png)


**How to enable Process Shield**

`var settings = new EzLibSettings
{
  ProcessSheild = true;
};`
