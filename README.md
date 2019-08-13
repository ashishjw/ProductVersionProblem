# ProductVersionProblem

This app solves product version problem stated below -
You have different products using different librarys with different version numbers.
You have to find all the products which are not using latest versions of the library.
Your input will be comma seperated strings in following format - Product,Library,Version No.

Sample Input
```
Mail Server, Authentication Library, v6
Video Call Server, Authentication Library, v7
Mail Server, Data Storage Library, v10
Chat Server, Data Storage Library, v11
Mail Server, Search Library, v6
Chat Server, Authentication Library, v8
Chat Server, Presence Library, v2
Video Call Server, Data Storage Library, v11
Video Call Server, Video Compression Library, v3
```

Expected Output
```
Mail Server
Video Call Server
```

Since "Mail Server" and "Video Call Server" were using older version of Authentication Library and Data Storage Library.
