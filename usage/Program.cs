using CYRUS_SIM800L;

SIM800L Sim800L = new SIM800L("COM18");
Sim800L.SendTextMessage("Hello Cyrus", "+254708830790");