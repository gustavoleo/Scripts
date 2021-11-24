/*
 * Title: Remove Columns Summarization  
 *
 * Author: Gustavo Leo    
 *
 * This script loops through all your columns in your model and set Default Summarization to "Don't summarize"
 *  https://youtu.be/vJNjLTc8NF0?t=100
 *
 */
foreach(var columns in Model.AllColumns)
{
    columns.SummarizeBy = AggregateFunction.None;
}