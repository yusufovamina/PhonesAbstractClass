using PhonesAbstractClass;

IFactory nokiaFactory = new NokiaFactory();
IProcessor nokiaProcessor = nokiaFactory.constructProcessor();
IPhone_ nokia = nokiaFactory.constructPhone();
nokia.constructPhone(nokiaProcessor);
