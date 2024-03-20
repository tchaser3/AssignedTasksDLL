/* Title:           Assigned Tasks Class
 * Date:            7-23-18
 * Author:          Terrance Holmes
 * 
 * Decription:      This is the class that assigns the task */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace AssignedTasksDLL
{
    public class AssignedTaskClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        AssignedTasksDataSet aAssignedTasksDataSet;
        AssignedTasksDataSetTableAdapters.assignedtasksTableAdapter aAssignedTasksTableAdapter;

        InsertAssignedTaskEntryTableAdapters.QueriesTableAdapter aInsertAssignedTaskTableAdapter;

        UpdateAssignedTaskEntryTableAdapters.QueriesTableAdapter aUpdateAssignedTaskTableAdapter;

        AssignedTasksUpdateDataSet aAssignedTasksUpdateDataSet;
        AssignedTasksUpdateDataSetTableAdapters.assignedtasksupdateTableAdapter aAssignedTasksUpdateTableAdapter;

        InsertAssignedTaskUpdateEntryTableAdapters.QueriesTableAdapter aInsertAssignedTaskUpdateTableAdapter;

        FindOpenAssignedTasksByEmployeeIDDataSet aFindOpenAssignedTasksByEmployeeIDDataSet;
        FindOpenAssignedTasksByEmployeeIDDataSetTableAdapters.FindOpenAssignedTaskByEmployeeIDTableAdapter aFindOpenAssignedTasksByEmployeeIDTableAdapter;

        FindAssignedTasksByAssignedEmployeeIDDataSet aFindAssignedTasksByAssignedEmployeeIDDataSet;
        FindAssignedTasksByAssignedEmployeeIDDataSetTableAdapters.FindAssignedTasksByAssignedEmployeeIDTableAdapter aFindAssignedTasksByAssignedEmployeeIDTableAdapter;

        FindAssignedTaskUpdateByTaskIDDataSet aFindAssignedTaskUpdateByTaskIDDataSet;
        FindAssignedTaskUpdateByTaskIDDataSetTableAdapters.FindAssignedTaskUpdateByTaskIDTableAdapter aFindAssignedTaskUpdateByTaskIDTableAdapter;

        UpdateAssignedTasksEmployeeIDEntryTableAdapters.QueriesTableAdapter aUpdateAssignedTasksEmployeeIDTableAdapter;

        FindAssignedTasksByTaskIDDataSet aFindAssignedTasksByTaskIDDataSet;
        FindAssignedTasksByTaskIDDataSetTableAdapters.FindAssignedTaskByTaskIDTableAdapter aFindAssignedTasksByTaskIDTableAdapter;

        AssignedEmployeeTasksDataSet aAssignedEmployeeTasksDataSet;
        AssignedEmployeeTasksDataSetTableAdapters.assignedemployeetasksTableAdapter aAssignedEmployeeTasksTableAdapter;

        FindAssignedTasksByDateMatchDataSet aFindAssignedTasksByDateMatchDataSet;
        FindAssignedTasksByDateMatchDataSetTableAdapters.FindAssignedTasksByDateMatchTableAdapter aFindAssignedTasksByDateMatchTableAdapter;

        FindAssignedTasksByOriginatingEmployeeIDDataSet aFindAssignedTasksbyOriginatingEmployeeIDDataSet;
        FindAssignedTasksByOriginatingEmployeeIDDataSetTableAdapters.FindAssignedTasksByOriginatingEmployeeIDTableAdapter aFindAssignedTasksByOriginatingEmployeeIDTableAdapter;

        FindOpenEmployeeAssignedTasksByTaskIDDataSet aFindOpenEmployeeAssignedTasksByTaskIDDataSet;
        FindOpenEmployeeAssignedTasksByTaskIDDataSetTableAdapters.FindOpenAssignedEmployeeTasksByTaskIDTableAdapter aFindOpenEmployeeAssignedTasksByTaskIDTableAdapter;

        InsertAssignedEmployeeTasksEntryTableAdapters.QueriesTableAdapter aInsertAssignedEmployeeTasksTableAdapter;

        FindOpenAssignedTasksDataSet aFindOpenAssignedTasksDataSet;
        FindOpenAssignedTasksDataSetTableAdapters.FindOpenAssignedTasksTableAdapter aFindOpenAssignedTasksTableAdapter;

        FindAssignedTasksByDateRangeDataSet aFindAssignedTasksByDateRangeDataSet;
        FindAssignedTasksByDateRangeDataSetTableAdapters.FindAssignedTaskByDateRangeTableAdapter aFindAssignedTasksByDateRangeTableAdapter;

        FindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet aFindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet;
        FindAssignedEmployeeTaskByEmployeeIDTaskIDDataSetTableAdapters.FindAssignedEmployeeTaskByEmployeeIDTaskIDTableAdapter aFindAssignedEmployeeTaskByEmployeeIDTaskIDTableAdapter;

        UpdateAssignedEmployeeTasksEntryTableAdapters.QueriesTableAdapter aUpdateAssignedEmployeeTaskTableAdapter;

        FindAssignedEmployeeTaskByTaskIDDataSet aFindAssignedEmployeeTaskByTaskIDDataSet;
        FindAssignedEmployeeTaskByTaskIDDataSetTableAdapters.FindAssignedEmployeeTasksByTaskIDTableAdapter aFindAssignedEmployeeTaskByTaskIDTableAdapter;

        FindAssignedTaskUpdateByTransactionIDDataSet aFindAssignedTaskUpdateByTransactionIDDataSet;
        FindAssignedTaskUpdateByTransactionIDDataSetTableAdapters.FindAssignedTaskUpdateByTransactionIDTableAdapter aFindAssignedTaskUpdateByTransactionIDTableAdapter;

        FindAllAssignedEmployeeTasksByEmployeeIDDataSet aFindAllAssignedEmployeeTasksByEmployeeIDDataSet;
        FindAllAssignedEmployeeTasksByEmployeeIDDataSetTableAdapters.FindAllAssignedEmployeeTasksByEmployeeIDTableAdapter aFindAllAssignedEmployeeTasksByEmployeeIDTableAdapter;

        public FindAllAssignedEmployeeTasksByEmployeeIDDataSet FindAllAssignedEmployeeTasksByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindAllAssignedEmployeeTasksByEmployeeIDDataSet = new FindAllAssignedEmployeeTasksByEmployeeIDDataSet();
                aFindAllAssignedEmployeeTasksByEmployeeIDTableAdapter = new FindAllAssignedEmployeeTasksByEmployeeIDDataSetTableAdapters.FindAllAssignedEmployeeTasksByEmployeeIDTableAdapter();
                aFindAllAssignedEmployeeTasksByEmployeeIDTableAdapter.Fill(aFindAllAssignedEmployeeTasksByEmployeeIDDataSet.FindAllAssignedEmployeeTasksByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find All Assigned Employee Tasks By Employee ID " + Ex.Message);
            }

            return aFindAllAssignedEmployeeTasksByEmployeeIDDataSet;
        }
        public FindAssignedTaskUpdateByTransactionIDDataSet FindAssignedTaskUpdateByTransactionID(int intTransactionID)
        {
            try
            {
                aFindAssignedTaskUpdateByTransactionIDDataSet = new FindAssignedTaskUpdateByTransactionIDDataSet();
                aFindAssignedTaskUpdateByTransactionIDTableAdapter = new FindAssignedTaskUpdateByTransactionIDDataSetTableAdapters.FindAssignedTaskUpdateByTransactionIDTableAdapter();
                aFindAssignedTaskUpdateByTransactionIDTableAdapter.Fill(aFindAssignedTaskUpdateByTransactionIDDataSet.FindAssignedTaskUpdateByTransactionID, intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Task Update By Transaction ID " + Ex.Message);
            }

            return aFindAssignedTaskUpdateByTransactionIDDataSet;
        }
        public FindAssignedEmployeeTaskByTaskIDDataSet FindAssignedEmployeeTaskByTaskID(int intTasksID)
        {
            try
            {
                aFindAssignedEmployeeTaskByTaskIDDataSet = new FindAssignedEmployeeTaskByTaskIDDataSet();
                aFindAssignedEmployeeTaskByTaskIDTableAdapter = new FindAssignedEmployeeTaskByTaskIDDataSetTableAdapters.FindAssignedEmployeeTasksByTaskIDTableAdapter();
                aFindAssignedEmployeeTaskByTaskIDTableAdapter.Fill(aFindAssignedEmployeeTaskByTaskIDDataSet.FindAssignedEmployeeTasksByTaskID, intTasksID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Employee Task By Task ID " + Ex.Message);
            }

            return aFindAssignedEmployeeTaskByTaskIDDataSet;
        }
        public bool UpdateAssignedEmployeeTask(int intTaskID, int intEmployeeID, bool blnCompleted)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAssignedEmployeeTaskTableAdapter = new UpdateAssignedEmployeeTasksEntryTableAdapters.QueriesTableAdapter();
                aUpdateAssignedEmployeeTaskTableAdapter.UpdateAssignedEmployeeTask(intTaskID, intEmployeeID, blnCompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Update Assigned Employe " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet FindAssignedEmployeeTaskByEmployeeIDTaskID(int intTaskID, int intEmployeeID)
        {
            try
            {
                aFindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet = new FindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet();
                aFindAssignedEmployeeTaskByEmployeeIDTaskIDTableAdapter = new FindAssignedEmployeeTaskByEmployeeIDTaskIDDataSetTableAdapters.FindAssignedEmployeeTaskByEmployeeIDTaskIDTableAdapter();
                aFindAssignedEmployeeTaskByEmployeeIDTaskIDTableAdapter.Fill(aFindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet.FindAssignedEmployeeTaskByEmployeeIDTaskID, intTaskID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Employee Task By Employee ID Task ID " + Ex.Message);
            }

            return aFindAssignedEmployeeTaskByEmployeeIDTaskIDDataSet;
        }
        public FindAssignedTasksByDateRangeDataSet FindAssignedTasksByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAssignedTasksByDateRangeDataSet = new FindAssignedTasksByDateRangeDataSet();
                aFindAssignedTasksByDateRangeTableAdapter = new FindAssignedTasksByDateRangeDataSetTableAdapters.FindAssignedTaskByDateRangeTableAdapter();
                aFindAssignedTasksByDateRangeTableAdapter.Fill(aFindAssignedTasksByDateRangeDataSet.FindAssignedTaskByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Tasks by Date Range " + Ex.Message);
            }

            return aFindAssignedTasksByDateRangeDataSet;
        }
        public FindOpenAssignedTasksDataSet FindOpenAssignedTasks()
        {
            try
            {
                aFindOpenAssignedTasksDataSet = new FindOpenAssignedTasksDataSet();
                aFindOpenAssignedTasksTableAdapter = new FindOpenAssignedTasksDataSetTableAdapters.FindOpenAssignedTasksTableAdapter();
                aFindOpenAssignedTasksTableAdapter.Fill(aFindOpenAssignedTasksDataSet.FindOpenAssignedTasks); 
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Open Assigned Tasks " + Ex.Message);
            }

            return aFindOpenAssignedTasksDataSet;
        }
        public FindOpenEmployeeAssignedTasksByTaskIDDataSet FindOpenEmployeeAssignedTaskByTaskID(int intTaskID)
        {
            try
            {
                aFindOpenEmployeeAssignedTasksByTaskIDDataSet = new FindOpenEmployeeAssignedTasksByTaskIDDataSet();
                aFindOpenEmployeeAssignedTasksByTaskIDTableAdapter = new FindOpenEmployeeAssignedTasksByTaskIDDataSetTableAdapters.FindOpenAssignedEmployeeTasksByTaskIDTableAdapter();
                aFindOpenEmployeeAssignedTasksByTaskIDTableAdapter.Fill(aFindOpenEmployeeAssignedTasksByTaskIDDataSet.FindOpenAssignedEmployeeTasksByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Open Employee Assigned Tasks By TaskID " + Ex.Message);
            }

            return aFindOpenEmployeeAssignedTasksByTaskIDDataSet;
        }
        public bool InsertAssignedEmployeeTasks(int intEmployeeID, int intTaskID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAssignedEmployeeTasksTableAdapter = new InsertAssignedEmployeeTasksEntryTableAdapters.QueriesTableAdapter();
                aInsertAssignedEmployeeTasksTableAdapter.InsertAssignedEmployeeTasks(intEmployeeID, intTaskID, DateTime.Now);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Insert Assigned Employee Tasks " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindAssignedTasksByOriginatingEmployeeIDDataSet FindAssignedTaskByOriginatingEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindAssignedTasksbyOriginatingEmployeeIDDataSet = new FindAssignedTasksByOriginatingEmployeeIDDataSet();
                aFindAssignedTasksByOriginatingEmployeeIDTableAdapter = new FindAssignedTasksByOriginatingEmployeeIDDataSetTableAdapters.FindAssignedTasksByOriginatingEmployeeIDTableAdapter();
                aFindAssignedTasksByOriginatingEmployeeIDTableAdapter.Fill(aFindAssignedTasksbyOriginatingEmployeeIDDataSet.FindAssignedTasksByOriginatingEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Task By Originating Employee ID  " + Ex.Message);
            }

            return aFindAssignedTasksbyOriginatingEmployeeIDDataSet;
        }
        public FindAssignedTasksByDateMatchDataSet FindAssignedTaskByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindAssignedTasksByDateMatchDataSet = new FindAssignedTasksByDateMatchDataSet();
                aFindAssignedTasksByDateMatchTableAdapter = new FindAssignedTasksByDateMatchDataSetTableAdapters.FindAssignedTasksByDateMatchTableAdapter();
                aFindAssignedTasksByDateMatchTableAdapter.Fill(aFindAssignedTasksByDateMatchDataSet.FindAssignedTasksByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Task By Date Match " + Ex.Message);
            }

            return aFindAssignedTasksByDateMatchDataSet;
        }
        public AssignedEmployeeTasksDataSet GetAssignedEmployeeTasksInfo()
        {
            try
            {
                aAssignedEmployeeTasksDataSet = new AssignedEmployeeTasksDataSet();
                aAssignedEmployeeTasksTableAdapter = new AssignedEmployeeTasksDataSetTableAdapters.assignedemployeetasksTableAdapter();
                aAssignedEmployeeTasksTableAdapter.Fill(aAssignedEmployeeTasksDataSet.assignedemployeetasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Get Assigned Employee Info " + Ex.Message);
            }

            return aAssignedEmployeeTasksDataSet;
        }
        public void UpdateAssignedEmployeeTasks(AssignedEmployeeTasksDataSet aAssignedEmployeeTasksDataSet)
        {
            try
            {
                aAssignedEmployeeTasksTableAdapter = new AssignedEmployeeTasksDataSetTableAdapters.assignedemployeetasksTableAdapter();
                aAssignedEmployeeTasksTableAdapter.Update(aAssignedEmployeeTasksDataSet.assignedemployeetasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Update Assigned Employee DB " + Ex.Message);
            }
        }
        public FindAssignedTasksByTaskIDDataSet FindAssignedTasksByTaskID(int intTaskID)
        {
            try
            {
                aFindAssignedTasksByTaskIDDataSet = new FindAssignedTasksByTaskIDDataSet();
                aFindAssignedTasksByTaskIDTableAdapter = new FindAssignedTasksByTaskIDDataSetTableAdapters.FindAssignedTaskByTaskIDTableAdapter();
                aFindAssignedTasksByTaskIDTableAdapter.Fill(aFindAssignedTasksByTaskIDDataSet.FindAssignedTaskByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Tasks By Task ID " + Ex.Message);
            }

            return aFindAssignedTasksByTaskIDDataSet;
        }
        public bool UpdateAssignedTasksEmployeeID(int intTaskID, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAssignedTasksEmployeeIDTableAdapter = new UpdateAssignedTasksEmployeeIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateAssignedTasksEmployeeIDTableAdapter.UpdateAssignedTasksEmployeeID(intTaskID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Update Assigned Tasks Employee ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindAssignedTaskUpdateByTaskIDDataSet FindAssignedTaskUpdateByTaskID(int intTaskID)
        {
            try
            {
                aFindAssignedTaskUpdateByTaskIDDataSet = new FindAssignedTaskUpdateByTaskIDDataSet();
                aFindAssignedTaskUpdateByTaskIDTableAdapter = new FindAssignedTaskUpdateByTaskIDDataSetTableAdapters.FindAssignedTaskUpdateByTaskIDTableAdapter();
                aFindAssignedTaskUpdateByTaskIDTableAdapter.Fill(aFindAssignedTaskUpdateByTaskIDDataSet.FindAssignedTaskUpdateByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Find Assigned Task Update By Task ID " + Ex.Message);
            }

            return aFindAssignedTaskUpdateByTaskIDDataSet;
        }
        public FindAssignedTasksByAssignedEmployeeIDDataSet FindAssignedTasksByAssignedEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindAssignedTasksByAssignedEmployeeIDDataSet = new FindAssignedTasksByAssignedEmployeeIDDataSet();
                aFindAssignedTasksByAssignedEmployeeIDTableAdapter = new FindAssignedTasksByAssignedEmployeeIDDataSetTableAdapters.FindAssignedTasksByAssignedEmployeeIDTableAdapter();
                aFindAssignedTasksByAssignedEmployeeIDTableAdapter.Fill(aFindAssignedTasksByAssignedEmployeeIDDataSet.FindAssignedTasksByAssignedEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Find Open Assigned Tasks By Assigned Employee ID " + Ex.Message);
            }

            return aFindAssignedTasksByAssignedEmployeeIDDataSet;
        }
        public FindOpenAssignedTasksByEmployeeIDDataSet FindOpenAssignedTasksByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindOpenAssignedTasksByEmployeeIDDataSet = new FindOpenAssignedTasksByEmployeeIDDataSet();
                aFindOpenAssignedTasksByEmployeeIDTableAdapter = new FindOpenAssignedTasksByEmployeeIDDataSetTableAdapters.FindOpenAssignedTaskByEmployeeIDTableAdapter();
                aFindOpenAssignedTasksByEmployeeIDTableAdapter.Fill(aFindOpenAssignedTasksByEmployeeIDDataSet.FindOpenAssignedTaskByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Find Open Assigned Tasks By Employee ID " + Ex.Message);
            }

            return aFindOpenAssignedTasksByEmployeeIDDataSet;
        }
        public bool InsertAssignedTaskUpdate(int intAssignedTaskID, int intEmployeeID, string strUpdateNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAssignedTaskUpdateTableAdapter = new InsertAssignedTaskUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertAssignedTaskUpdateTableAdapter.InsertAssignedTaskUpdate(intAssignedTaskID, intEmployeeID, DateTime.Now, strUpdateNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Insert Assigned Task Update " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }

        public AssignedTasksUpdateDataSet GetAssignedTaskUpdateInfo()
        {
            try
            {
                aAssignedTasksUpdateDataSet = new AssignedTasksUpdateDataSet();
                aAssignedTasksUpdateTableAdapter = new AssignedTasksUpdateDataSetTableAdapters.assignedtasksupdateTableAdapter();
                aAssignedTasksUpdateTableAdapter.Fill(aAssignedTasksUpdateDataSet.assignedtasksupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Get Assigned Tasks Update Info " + Ex.Message);
            }

            return aAssignedTasksUpdateDataSet;
        }
        public void UpdateAssignedTaskUpdateDB(AssignedTasksUpdateDataSet aAssignedTasksUpdateDataSet)
        {
            try
            {
                aAssignedTasksUpdateTableAdapter = new AssignedTasksUpdateDataSetTableAdapters.assignedtasksupdateTableAdapter();
                aAssignedTasksUpdateTableAdapter.Update(aAssignedTasksUpdateDataSet.assignedtasksupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Update Assigned Tasks Update DB " + Ex.Message);
            }
        }
        public bool UpdateAssignedTask(int intTransactionID, DateTime datCompletionDate, bool blnTaskCompleted)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAssignedTaskTableAdapter = new UpdateAssignedTaskEntryTableAdapters.QueriesTableAdapter();
                aUpdateAssignedTaskTableAdapter.UpdateAssignedTasks(intTransactionID, datCompletionDate, blnTaskCompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Update Assigned Task " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertAssignedTask(int intOriginatingEmployeeID, DateTime datTransactionDate, string strMessageSubject, string strMessageText)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAssignedTaskTableAdapter = new InsertAssignedTaskEntryTableAdapters.QueriesTableAdapter();
                aInsertAssignedTaskTableAdapter.InsertAssignedTasks(intOriginatingEmployeeID, datTransactionDate, DateTime.Now, strMessageSubject, strMessageText);

            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Task Class // Insert Assigned Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public AssignedTasksDataSet GetAssignedTasksInfo()
        {
            try
            {
                aAssignedTasksDataSet = new AssignedTasksDataSet();
                aAssignedTasksTableAdapter = new AssignedTasksDataSetTableAdapters.assignedtasksTableAdapter();
                aAssignedTasksTableAdapter.Fill(aAssignedTasksDataSet.assignedtasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Get Assigned Tasks Info " + Ex.Message);
            }

            return aAssignedTasksDataSet;
        }
        public void UpdateAssignedTasksDB(AssignedTasksDataSet aAssignedTasksDataSet)
        {
            try
            {
                aAssignedTasksTableAdapter = new AssignedTasksDataSetTableAdapters.assignedtasksTableAdapter();
                aAssignedTasksTableAdapter.Update(aAssignedTasksDataSet.assignedtasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Assigned Tasks Class // Update Assigned Tasks DB " + Ex.Message);
            }
        }
    }
}
