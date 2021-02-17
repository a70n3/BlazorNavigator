# BlazorNavigator
Reusable Pagination Component for Blazor

![alt text](https://github.com/a70n3/BlazorNavigator/blob/master/screenshot.PNG)
## Installing
You can install from NuGet using the following command:
```sh
Install-Package BlazoreNavigator
```
Or via the Visual Studio package manger.

## Usage
```sh
<table>
  ...
</table>
<BlazorNavigator 
                NumberOfPages="@NumberOfPages" 
                OnClick="@Search"/>
                
@code{
    public async Task Search(int pageNum) {
        //code to fetch paged result using pageNum as offset to your sql query
    }
}
```
## Note
The pagination button will only show if the number of pages is more than 1.
