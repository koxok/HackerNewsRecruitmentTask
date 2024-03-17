# HackerNewsRecruitmentTask
HackerNews Recruitment Task


How to run:
1.
  a) inside HackerNews/HackerNews run cmd and execute dotnet run command (NET 7)
  b) build and run application using IDE
2. Application should start on http://localhost:5275
3. You can access swagger on http://localhost:5275/swagger


Assumptions:
  best stories are already sorted, so there is no need to sort it again by score.

Enhancemets:
  - better usage of cache (checking if story details are already in cache instead of replacing.
  - better usage of Firebase (getting best stories ids is made based on firestore update policy)
  - usage of configuration files (appsettings.json)
  - exception handling
  - the service is dependant only on Hacker News API, so before deploying to Environment create Healthcheck policy
  - against using In-memory cache, could use some kind of Redis (but for this task, it would be overkill.
