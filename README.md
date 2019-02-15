# DocFactory
Purpose of this application is to ease creation of multiple, similar documents.

Work mechanism:<br/>
Application reads data from specified input table. Basing on number of data rows, copies of document are created in specified output folder.  Then, for each copy of document, tags found in document are replaced with these stored in data table. 
<br/><br/>
Usage:
<br/>
You have to define input for the application. It consists from 2 files and an output directory. Description enclosed:

1. Input data file:
You'll need an Excel file with your input data. Store your data in columns. Anywhere in the first row of the table insert "&lt;Filename&gt;". Other tags can contain any string, yet I suggest to keep it inside angle brackets. Save your data template in .xslx format.

Important remarks:

a) All cells inside a row must be filled in, i.e. if you've got 10 tags, you shall have 10 non-empty cells in each row. If this condition is not met, then that row will be omitted. If you want to have an empty cell, write following function to cell: ="".
    
b) If you want to clear a row (or column), use "Delete row" (or "Delete column") Excel function. Delete key clears values of cells, but for some reason Excel reader sees it as empty strings instead of nulls.
    
c) If you omit "&lt;Filename&gt;" tag in input data file, files won't be created.
    
2. Document template:
Application replaces all occurences of tags in document template with values read from data file (except "<Filename>" tag).
Your output files can be found in specified output folder.
    
3. Output folder:
Specify any folder you can write to. Omitting this condition will cause an exception error and files will not be created.

Files are being processed as soon as you click "Create files" button. When operation is complete, 2 buttons will appear in tool strip:
1. Open output folder button - click on it to open output folder with explorer.exe.
2. Open log file - click on it to see log file with notepad.exe.
