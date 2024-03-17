# HackerNewsRecruitmentTask
HackerNews Recruitment Task


How to run: <br>
1. <br>
    a) inside HackerNews/HackerNews run cmd and execute dotnet run command (NET 7)<br>
    b) build and run application using IDE<br>
2. Application should start on http://localhost:5275 <br>
3. You can access swagger on http://localhost:5275/swagger <br>


Assumptions:<br>
  best stories are already sorted, so there is no need to sort it again by score.

Enhancemets:
  - better usage of cache (checking if story details are already in cache instead of replacing.
  - better usage of Firebase (getting best stories ids is made based on firestore update policy)
  - usage of configuration files (appsettings.json)
  - exception handling
  - the service is dependant only on Hacker News API, so before deploying to Environment create Healthcheck policy
  - against using In-memory cache, could use Redis  (but for this task, it would be overkill.)
