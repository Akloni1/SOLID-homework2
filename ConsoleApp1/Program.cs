using SOLID_homework2;
using SOLID_homework2.Appenders;
using SOLID_homework2.Layout;
using SOLID_homework2.Logger;

var simpleLayout = new SimpleLayout();

var consoleAppender = new ConsoleAppender(simpleLayout);



var file = new LogFile();

var fileAppender = new FileAppender(simpleLayout, file);



var logger = new Logger(consoleAppender, fileAppender);

logger.Error("3/26/2022 2:08:11 PM", "Error parsing JSON.");

logger.Info("3/26/2022 2:08:11 PM", "User Ivan successfully registered.");