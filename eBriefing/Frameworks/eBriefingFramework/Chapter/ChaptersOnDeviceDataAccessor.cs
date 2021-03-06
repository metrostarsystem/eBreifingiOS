/*
Copyright (C) 2017 MetroStar Systems

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

The full license text can be found is the included LICENSE file.

You can freely use any of this software which you make publicly 
available at no charge.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>
*/

using System;
using System.Collections.Generic;

namespace eBriefingMobile
{
    public static class ChaptersOnDeviceDataAccessor
    {
        private static PersistantStorageDatabase<Chapter> _database = new PersistantStorageDatabase<Chapter>("chapters");

        public static void AddChapters(String bookID, List<Chapter> chapterList)
        {
            if (chapterList != null)
            {
                _database.StartBatchUpdate(bookID);

                _database.ClearTable(bookID);

                foreach (var chapter in chapterList)
                {
                    _database.SetRecord(bookID, chapter.ID, chapter);
                }
                _database.EndBatchUpdate(bookID);
            }
        }

        public static void RemoveChapters(String bookID)
        {
            _database.DeleteTable(bookID);
        }

        public static void UpdateChapters(String bookID, List<Chapter> chapterList)
        {
            AddChapters(bookID, chapterList);
        }

        public static List<Chapter> GetChapters(String bookID)
        {
            return _database.GetRecordsInTable(bookID);
        }

        public static Chapter GetChapter(String bookID, String chapterID)
        {
            return _database.GetRecord(bookID, chapterID);
        }
    }
}

