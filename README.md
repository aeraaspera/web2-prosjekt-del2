# Project: DEL 2
---

## Introduction

New github repository was created.

It contains previous project (del 1).

main branch tilsvarer prosjekt - del 1
release branch tilsvarer prosjekt - del 2

The following GIT commands were used in the project:

- git add README.md
- git branch -M main

- git add .
- git commit -m "text" 
- git push -u origin "branch"
- git tag -a v1.0.0 -m "text" 
- git push origin v1.0.0
- git tag --merged "branch"

It was created main + 10 branches that contain various features.
Each feature has its own tag.

0. main branch **[tag v.0.0]**
1. "feature-display-UserName-on-the-HomePage" **[tag v.0.1]**
2. "feature-design-part-1" **[tag v.0.2]**
3. "feature-display-DateCreated-of-the-posts" **[tag v.0.3]**
4. "feature-display-DateCreated-of-the-comments" **[tag v.0.4]**
5. "feature-sort-posts-by-DateCreated" **[tag v.0.5]**
6. "feature-upload-an-image-from-local-storage-and-display-on-the-PostDetails-page" **[tag v.0.6]**
7. "feature-delete-post" **[tag v.0.70]**
8. "feature-design-part-2" **[tag v.0.8]**
9. "feature-sort-comments-by-DateCreated" **[tag v.0.9]**
10. "feature-undo-the-creation-of-comments" **[tag v.0.10]**
11. "feature-like-button" is based on release branch **[tag v.0.11]**
release branch
---
# web2-prosjekt-del2

# 11.12.2023
## Feature "feature-display-UserName-on-the-HomePage"
If user is logged inn, then user's name is displayed on the HomePage.  

Otherwise, the name "Guest" is displayed.

## Feature "feature-design-part-1"
MudContainer is added and styled in all files

navbar and footer are fixed

Design for BlogItem, PostItem and CommentItem is changed

Design of Index files and forms is changed

Headers for blogs, posts and comments are deleted

Index.razor.css files are deleted

Back buttons are deleted

New color pallete is used for alle elements: text, buttons etc.

## Feature "feature-display-DateCreated-of-the-posts"
new property "DateCreated" is added to dto, entities, viewmodels, postcontroller

new migration + update database

new layout to display DateCreated og the post

## Feature "feature-display-DateCreated-of-the-comments"

DateCreated is added to models/dto,entity,viewmodel

New MudText is added to CommentItem to display DateCreated

# 12.12.2023

## Feature: "feature-sort-posts-by-DateCreated"
Posts can be sorted by date created.

New task SortPosts() and corresporende button are added to Post/Index.razor page.

## Feature: "feature-upload-an-image-from-local-storage-and-display-on-the-PostDetails-page"
Authorized user can select an image from local storage and use / display it at post creation.

uploads folder

MudImage in PostDetailsItem

IFileUploadService. FileUploadService. Register i Program.cs

form for uploading the files and new function OnInputFileChange()

fileName - postdto, post, postcreatemodel, postmodel, PostController etc

new migration and updating of the database

# 13.12.2023

## Feature: "feature-delete-post"
Authorized user can delete its own post.

Delete button is added

Diaglog to delete post is added

Neccessery functionality to delete post and related changes in other files are added 

Resouce authorization and policy are used

# 14.12.2023

## Feature: "feature-design-part-2"
Styling of the main elements as colors of the buttons, text etc.

Background image for HomePage (transparent). Image is taken from http://www.freepik.com.

Styling of the navbar: register and login/logout are aligned to the right.

BlogID is displayed in the PostDetails page.

Changes in ApplicationDbContext.

# 15.12.2023

## Feature: "feature-sort-comments-by-DateCreated"
Comments can be sorted by date created.

DateCreated parameter is used.

New button to sort comments by date created.

Functionality (sortComments) to sort comments is added.

Changes in ApplicationDbContext to display more information / posts in closed blog.

# 16.12.2023
## Feature: "feature-undo-the-creation-of-comments"
Authorized user can delete its own comment.  

The user har the opportunity to undo the deletion of a comment within 30 seconds. 

# 18.12.2023
## Feature: "feature-like-button"
Authorized user can "like" the post. The icon changes its color when its clicked. 
And the count of "likes" is incremented by one.  

