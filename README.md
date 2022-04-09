# FeedbackToolDissertation
<!-- ABOUT THE PROJECT -->
## About The Project
A feedback tool that allows academics to save feedback to a database to be used again.

A final year project submitted as part of a Bsc in Computer Science 




Project Link: [https://github.com/KieranRobson/600091_HonoursStageProject](https://github.com/KieranRobson/600091_HonoursStageProject)


## Built With
* [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
* [Azure](https://azure.microsoft.com/en-gb/features/azure-portal/)


<!-- GETTING STARTED -->
## Getting Started
        <h3>Getting Started</h3>
        <h4>Layout</h4>
        <h5>The grading page is broken into 2 distinct parts. At the top you will see the details section where you will enter the student number, module and acw that you would like to grade.</h5>
        <h5>Below the details part is the feedback section where you will add feedback and break the acw down into sections, criteria and feedback.</h5>
        <br />
        <h5>The application utilises selection boxes similarly to the one below allowing you to choose what section, criteria or feedback youd like to utilise. </h5>
        <select autocomplete="off">
            <option value="" selected="selected" hidden>Select your Module</option>
            <option value="">Example Module 1</option>
            <option value="">Example Module 2</option>
        </select>
        <br />
        <br />
        <br />
        <h4>Buttons</h4>
        <h5>Pressing the '<button type="button" class="btn btn-primary">+</button>' will allow you to add data to the database. Each selection box will have a button next to them and allow you to add data for that respective selection box.</h5>
        <h5>Pressing the '<button type="button" class="btn btn-danger">-</button>' will allow you to delete data from the database. Each selection box will have a button next to them and allow you to delete data for that respective selection box.</h5>
        <br />
        <h5>The '<button type="button" class="btn btn-primary">Show New Section</button>' button will display two extra sections allowing for more feedback</h5>
        <br />
        <h5>Finally, pressing the '<button type="button" class="btn btn-primary">Export To Text Document</button>' button will export any data within the form to a text document and will be named the student number entered at the top of the form. If you do not enter a student number, you will not be able to export. </h5>
        <br />
        <br />
        <h4>You can begin grading by pressing the "Grading" option on the sidebar! or press <a href="/Grading">Click Here</a></h4>


1. Download Code 
2. Open Visual Studio
3. Press Run!


<!-- ACKNOWLEDGMENTS -->
## Acknowledgments
* [BlazorDownloadFile](https://github.com/arivera12/BlazorDownloadFile)
