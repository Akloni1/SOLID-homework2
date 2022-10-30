using SOLID_homework2.Appenders;
using SOLID_homework2.Layout;
using SOLID_homework2.Logger;

ILayout simpleLayout = new SimpleLayout();

IAppender consoleAppender = new ConsoleAppender(simpleLayout);

ILogger logger = new Logger(consoleAppender);



logger.Error("3/26/2022 2:08:11 PM", "Error parsing JSON.");

logger.Info("3/26/2022 2:08:11 PM", "User Ivan successfully registered.");