﻿/*
    Copyright (C) 2015  Jack Fagner

    This file is part of OpenTidl.

    OpenTidl is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    OpenTidl is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with OpenTidl.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTidl.Models.Base;
using System.Runtime.Serialization;
using OpenTidl.Transport;

namespace OpenTidl.Models
{
    [DataContract]
    public class ClientModel : ModelBase
    {
        [DataMember(Name = "authorizedForOffline")]
        public Boolean AuthorizedForOffline { get; private set; }

        [IgnoreDataMember]
        public DateTime? AuthorizedForOfflineDate { get; private set; }

        [IgnoreDataMember]
        public DateTime? Created { get; private set; }

        [DataMember(Name = "id")]
        public Int32 Id { get; private set; }

        [IgnoreDataMember]
        public DateTime? LastLogin { get; private set; }

        [DataMember(Name = "name")]
        public String Name { get; private set; }

        [DataMember(Name = "numberOfOfflineAlbums")]
        public Int32 NumberOfOfflineAlbums { get; private set; }

        [DataMember(Name = "numberOfOfflinePlaylists")]
        public Int32 NumberOfOfflinePlaylists { get; private set; }

        [DataMember(Name = "uniqueKey")]
        public String UniqueKey { get; private set; }

        [DataMember(Name = "application")]
        public ApplicationModel Application { get; private set; }


        #region json helpers

        [DataMember(Name = "authorizedForOfflineDate")]
        private String AuthorizedForOfflineDateHelper
        {
            get { return RestUtility.FormatDate(AuthorizedForOfflineDate); }
            set { AuthorizedForOfflineDate = RestUtility.ParseDate(value); }
        }

        [DataMember(Name = "created")]
        private String CreatedDateHelper
        {
            get { return RestUtility.FormatDate(Created); }
            set { Created = RestUtility.ParseDate(value); }
        }

        [DataMember(Name = "lastLogin")]
        private String LastLoginDateHelper
        {
            get { return RestUtility.FormatDate(LastLogin); }
            set { LastLogin = RestUtility.ParseDate(value); }
        }

        #endregion
    }
}
