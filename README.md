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
                RecordPerPage="@NumberOfRecordsPerPage" 
                OnClick="Search"/>
                
@code{
    public async Task Search(int pageNum) {
        //fetch data
    }
}
```
