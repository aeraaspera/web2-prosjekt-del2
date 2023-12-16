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
New task SortPosts() and corresporende button are added to Post/Index.razor page.

## Feature: "feature-upload-an-image-from-local-storage-and-display-on-the-PostDetails-page"

uploads folder

MudImage in PostDetailsItem

IFileUploadService. FileUploadService. Register i Program.cs

form for uploading the files and new function OnInputFileChange()

fileName - postdto, post, postcreatemodel, postmodel, PostController etc

new migration and updating of the database

# 13.12.2023

## Feature: "feature-delete-post"
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
DateCreated parameter is used.

New button to sort comments by date created.

Functionality (sortComments) to sort comments is added.

Changes in ApplicationDbContext to display more information / posts in closed blog.


