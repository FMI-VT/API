////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="CheckPermissions.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the check permissions class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Common.Permissions
{
    using System;
    using System.Security.AccessControl;
    using System.Security.Principal;
    using PrimeHolding.Tools.Common.Exceptions;

    /// <summary>   A check permissions. </summary>
    public class CheckPermissions
    {

        /// <summary>   Full pathname of the file. </summary>
        private string path;
        
        /// <summary>   The principal. </summary>
        private WindowsIdentity principal;

        /// <summary>   True to deny, false to allow append data. </summary>
        private bool denyAppendData = false;
        /// <summary>   True to deny, false to allow change permissions. </summary>
        private bool denyChangePermissions = false;
        /// <summary>   True to deny, false to allow create directories. </summary>
        private bool denyCreateDirectories = false;
        /// <summary>   True to deny, false to allow create files. </summary>
        private bool denyCreateFiles = false;
        /// <summary>   True to deny, false to allow delete. </summary>
        private bool denyDelete = false;
        /// <summary>   True to deny, false to allow delete subdirectories and files. </summary>
        private bool denyDeleteSubdirectoriesAndFiles = false;
        /// <summary>   True to deny, false to allow execute file. </summary>
        private bool denyExecuteFile = false;
        /// <summary>   True to deny, false to allow full control. </summary>
        private bool denyFullControl = false;
        /// <summary>   True to deny, false to allow list directory. </summary>
        private bool denyListDirectory = false;
        /// <summary>   True to deny, false to allow modify. </summary>
        private bool denyModify = false;
        /// <summary>   True to deny, false to allow read. </summary>
        private bool denyRead = false;
        /// <summary>   True to deny, false to allow read and execute. </summary>
        private bool denyReadAndExecute = false;
        /// <summary>   True to deny, false to allow read attributes. </summary>
        private bool denyReadAttributes = false;
        /// <summary>   True to deny, false to allow read data. </summary>
        private bool denyReadData = false;
        /// <summary>   True to deny, false to allow read extended attributes. </summary>
        private bool denyReadExtendedAttributes = false;
        /// <summary>   True to deny, false to allow read permissions. </summary>
        private bool denyReadPermissions = false;
        /// <summary>   True to deny, false to allow synchronize. </summary>
        private bool denySynchronize = false;
        /// <summary>   True to deny, false to allow take ownership. </summary>
        private bool denyTakeOwnership = false;
        /// <summary>   True to deny, false to allow traverse. </summary>
        private bool denyTraverse = false;
        /// <summary>   True to deny, false to allow write. </summary>
        private bool denyWrite = false;
        /// <summary>   True to deny, false to allow write attributes. </summary>
        private bool denyWriteAttributes = false;
        /// <summary>   True to deny, false to allow write data. </summary>
        private bool denyWriteData = false;
        /// <summary>   True to deny, false to allow write extended attributes. </summary>
        private bool denyWriteExtendedAttributes = false;

        /// <summary>   True to allow, false to deny append data. </summary>
        private bool allowAppendData = false;
        /// <summary>   True to allow, false to deny change permissions. </summary>
        private bool allowChangePermissions = false;
        /// <summary>   True to allow, false to deny create directories. </summary>
        private bool allowCreateDirectories = false;
        /// <summary>   True to allow, false to deny create files. </summary>
        private bool allowCreateFiles = false;
        /// <summary>   True to allow, false to deny delete. </summary>
        private bool allowDelete = false;
        /// <summary>   True to allow, false to deny delete subdirectories and files. </summary>
        private bool allowDeleteSubdirectoriesAndFiles = false;
        /// <summary>   True to allow, false to deny execute file. </summary>
        private bool allowExecuteFile = false;
        /// <summary>   True to allow, false to deny full control. </summary>
        private bool allowFullControl = false;
        /// <summary>   True to allow, false to deny list directory. </summary>
        private bool allowListDirectory = false;
        /// <summary>   True to allow, false to deny modify. </summary>
        private bool allowModify = false;
        /// <summary>   True to allow, false to deny read. </summary>
        private bool allowRead = false;
        /// <summary>   True to allow, false to deny read and execute. </summary>
        private bool allowReadAndExecute = false;
        /// <summary>   True to allow, false to deny read attributes. </summary>
        private bool allowReadAttributes = false;
        /// <summary>   True to allow, false to deny read data. </summary>
        private bool allowReadData = false;
        /// <summary>   True to allow, false to deny read extended attributes. </summary>
        private bool allowReadExtendedAttributes = false;
        /// <summary>   True to allow, false to deny read permissions. </summary>
        private bool allowReadPermissions = false;
        /// <summary>   True to allow, false to deny synchronize. </summary>
        private bool allowSynchronize = false;
        /// <summary>   True to allow, false to deny take ownership. </summary>
        private bool allowTakeOwnership = false;
        /// <summary>   True to allow, false to deny traverse. </summary>
        private bool allowTraverse = false;
        /// <summary>   True to allow, false to deny write. </summary>
        private bool allowWrite = false;
        /// <summary>   True to allow, false to deny write attributes. </summary>
        private bool allowWriteAttributes = false;
        /// <summary>   True to allow, false to deny write data. </summary>
        private bool allowWriteData = false;
        /// <summary>   True to allow, false to deny write extended attributes. </summary>
        private bool allowWriteExtendedAttributes = false;

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can append data. </summary>
        ///
        /// <returns>   True if we can append data, false if not. </returns>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public bool CanAppendData()
        {
            return !denyAppendData && allowAppendData;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can change permissions. </summary>
        ///
        /// <returns>   True if we can change permissions, false if not. </returns>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public bool CanChangePermissions()
        {
            return !denyChangePermissions && allowChangePermissions;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can create directories. </summary>
        ///
        /// <returns>   True if we can create directories, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanCreateDirectories()
        {
            return !denyCreateDirectories && allowCreateDirectories;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can create files. </summary>
        ///
        /// <returns>   True if we can create files, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanCreateFiles()
        {
            return !denyCreateFiles && allowCreateFiles;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can delete. </summary>
        ///
        /// <returns>   True if we can delete, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanDelete()
        {
            return !denyDelete && allowDelete;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can delete subdirectories and files. </summary>
        ///
        /// <returns>   True if we can delete subdirectories and files, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanDeleteSubdirectoriesAndFiles()
        {
            return !denyDeleteSubdirectoriesAndFiles && allowDeleteSubdirectoriesAndFiles;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can execute file. </summary>
        ///
        /// <returns>   True if we can execute file, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanExecuteFile()
        {
            return !denyExecuteFile && allowExecuteFile;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can full control. </summary>
        ///
        /// <returns>   True if we can full control, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanFullControl()
        {
            return !denyFullControl && allowFullControl;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can list directory. </summary>
        ///
        /// <returns>   True if we can list directory, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanListDirectory()
        {
            return !denyListDirectory && allowListDirectory;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can modify. </summary>
        ///
        /// <returns>   True if we can modify, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanModify()
        {
            return !denyModify && allowModify;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can read. </summary>
        ///
        /// <returns>   True if we can read, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanRead()
        {
            return !denyRead && allowRead;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can read and execute. </summary>
        ///
        /// <returns>   True if we can read and execute, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanReadAndExecute()
        {
            return !denyReadAndExecute && allowReadAndExecute;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can read attributes. </summary>
        ///
        /// <returns>   True if we can read attributes, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanReadAttributes()
        {
            return !denyReadAttributes && allowReadAttributes;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can read data. </summary>
        ///
        /// <returns>   True if we can read data, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanReadData()
        {
            return !denyReadData && allowReadData;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can read extended attributes. </summary>
        ///
        /// <returns>   True if we can read extended attributes, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanReadExtendedAttributes()
        {
            return !denyReadExtendedAttributes && allowReadExtendedAttributes;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can read permissions. </summary>
        ///
        /// <returns>   True if we can read permissions, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanReadPermissions()
        {
            return !denyReadPermissions && allowReadPermissions;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can synchronize. </summary>
        ///
        /// <returns>   True if we can synchronize, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanSynchronize()
        {
            return !denySynchronize && allowSynchronize;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can take ownership. </summary>
        ///
        /// <returns>   True if we can take ownership, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanTakeOwnership()
        {
            return !denyTakeOwnership && allowTakeOwnership;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can traverse. </summary>
        ///
        /// <returns>   True if we can traverse, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanTraverse()
        {
            return !denyTraverse && allowTraverse;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can write. </summary>
        ///
        /// <returns>   True if we can write, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanWrite()
        {
            return !denyWrite && allowWrite;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can write attributes. </summary>
        ///
        /// <returns>   True if we can write attributes, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanWriteAttributes()
        {
            return !denyWriteAttributes && allowWriteAttributes;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can write data. </summary>
        ///
        /// <returns>   True if we can write data, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanWriteData()
        {
            return !denyWriteData && allowWriteData;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Determine if we can write extended attributes. </summary>
        ///
        /// <returns>   True if we can write extended attributes, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool CanWriteExtendedAttributes()
        {
            return !denyWriteExtendedAttributes && allowWriteExtendedAttributes;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets windows identity. </summary>
        ///
        /// <returns>   The windows identity. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public WindowsIdentity GetWindowsIdentity() => principal;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the path. </summary>
        ///
        /// <returns>   The path. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string GetPath()
        {
            return path;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the PrimeHolding.Tools.Common.Permissions.CheckPermissions
        ///     class.
        /// </summary>
        ///
        /// <param name="path"> Full pathname of the file. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CheckPermissions(string path) : this(path, WindowsIdentity.GetCurrent()) {}

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the PrimeHolding.Tools.Common.Permissions.CheckPermissions
        ///     class.
        /// </summary>
        ///
        /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
        ///
        /// <param name="path">         Full pathname of the file. </param>
        /// <param name="principal">    The principal. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CheckPermissions(string path, WindowsIdentity principal)
        {
            this.path = path;
            this.principal = principal;

            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(path);
                AuthorizationRuleCollection acl = fi.GetAccessControl().GetAccessRules(true, true, typeof(SecurityIdentifier));
                for (int i = 0; i < acl.Count; i++)
                {
                    FileSystemAccessRule rule = (FileSystemAccessRule)acl[i];
                    if (principal.User.Equals(rule.IdentityReference))
                    {
                        if (AccessControlType.Deny.Equals(rule.AccessControlType))
                        {
                            if (Contains(FileSystemRights.AppendData, rule))
                            {
                                denyAppendData = true;
                            }
                                
                            if (Contains(FileSystemRights.ChangePermissions, rule))
                            {
                                denyChangePermissions = true;
                            }
                                
                            if (Contains(FileSystemRights.CreateDirectories, rule))
                            {
                                denyCreateDirectories = true;
                            }
                                
                            if (Contains(FileSystemRights.CreateFiles, rule))
                            {
                                denyCreateFiles = true;
                            }
                                
                            if (Contains(FileSystemRights.Delete, rule))
                            {
                                denyDelete = true;
                            }

                            if (Contains(FileSystemRights.DeleteSubdirectoriesAndFiles, rule))
                            {
                                denyDeleteSubdirectoriesAndFiles = true;
                            }

                            if (Contains(FileSystemRights.ExecuteFile, rule))
                            {
                                denyExecuteFile = true;
                            }

                            if (Contains(FileSystemRights.FullControl, rule)) { 
                                denyFullControl = true;
                            }

                            if (Contains(FileSystemRights.ListDirectory, rule))
                            {
                                denyListDirectory = true;
                            }
                                
                            if (Contains(FileSystemRights.Modify, rule))
                            {
                                denyModify = true;
                            }

                            if (Contains(FileSystemRights.Read, rule))
                            {
                                denyRead = true;
                            }

                            if (Contains(FileSystemRights.ReadAndExecute, rule))
                            {
                                denyReadAndExecute = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadAttributes, rule))
                            {
                                denyReadAttributes = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadData, rule))
                            {
                                denyReadData = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadExtendedAttributes, rule))
                            {
                                denyReadExtendedAttributes = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadPermissions, rule))
                            {
                                denyReadPermissions = true;
                            }
                                
                            if (Contains(FileSystemRights.Synchronize, rule))
                            {
                                denySynchronize = true;
                            }
                                
                            if (Contains(FileSystemRights.TakeOwnership, rule))
                            {
                                denyTakeOwnership = true;
                            }
                                
                            if (Contains(FileSystemRights.Traverse, rule))
                            {
                                denyTraverse = true;
                            }
                                
                            if (Contains(FileSystemRights.Write, rule))
                            {
                                denyWrite = true;
                            }
                                
                            if (Contains(FileSystemRights.WriteAttributes, rule))
                            {
                                denyWriteAttributes = true;
                            }
                                
                            if (Contains(FileSystemRights.WriteData, rule))
                            {
                                denyWriteData = true;
                            }
                                
                            if (Contains(FileSystemRights.WriteExtendedAttributes, rule))
                            {
                                denyWriteExtendedAttributes = true;
                            }
                        }
                        else if (AccessControlType.Allow.Equals(rule.AccessControlType)) {
                            if (Contains(FileSystemRights.AppendData, rule))
                            {
                                allowAppendData = true;
                            }
                                
                            if (Contains(FileSystemRights.ChangePermissions, rule))
                            {
                                allowChangePermissions = true;
                            }
                                
                            if (Contains(FileSystemRights.CreateDirectories, rule))
                            {
                                allowCreateDirectories = true;
                            }
                                
                            if (Contains(FileSystemRights.CreateFiles, rule))
                            {
                                allowCreateFiles = true;
                            }
                                
                            if (Contains(FileSystemRights.Delete, rule))
                            {
                                allowDelete = true;
                            }
                                
                            if (Contains(FileSystemRights.DeleteSubdirectoriesAndFiles, rule))
                            {
                                allowDeleteSubdirectoriesAndFiles = true;
                            }
                                
                            if (Contains(FileSystemRights.ExecuteFile, rule))
                            {
                                allowExecuteFile = true;
                            }
                                
                            if (Contains(FileSystemRights.FullControl, rule))
                            {
                                allowFullControl = true;
                            }
                                
                            if (Contains(FileSystemRights.ListDirectory, rule))
                            {
                                allowListDirectory = true;
                            }
                                
                            if (Contains(FileSystemRights.Modify, rule))
                            {
                                allowModify = true;
                            }
                                
                            if (Contains(FileSystemRights.Read, rule))
                            {
                                allowRead = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadAndExecute, rule))
                            {
                                allowReadAndExecute = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadAttributes, rule))
                            {
                                allowReadAttributes = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadData, rule))
                            {
                                allowReadData = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadExtendedAttributes, rule))
                            {
                                allowReadExtendedAttributes = true;
                            }
                                
                            if (Contains(FileSystemRights.ReadPermissions, rule))
                            {
                                allowReadPermissions = true;
                            }
                                
                            if (Contains(FileSystemRights.Synchronize, rule))
                            {
                                allowSynchronize = true;
                            }
                                
                            if (Contains(FileSystemRights.TakeOwnership, rule))
                            {
                                allowTakeOwnership = true;
                            }
                                
                            if (Contains(FileSystemRights.Traverse, rule))
                            {
                                allowTraverse = true;
                            }
                                
                            if (Contains(FileSystemRights.Write, rule))
                            {
                                allowWrite = true;
                            }
                                
                            if (Contains(FileSystemRights.WriteAttributes, rule))
                            {
                                allowWriteAttributes = true;
                            }
                                
                            if (Contains(FileSystemRights.WriteData, rule))
                            {
                                allowWriteData = true;
                            }
                                
                            if (Contains(FileSystemRights.WriteExtendedAttributes, rule))
                            {
                                allowWriteExtendedAttributes = true;
                            }  
                        }
                    }
                }

                IdentityReferenceCollection groups = principal.Groups;
                for (int j = 0; j < groups.Count; j++)
                {
                    for (int i = 0; i < acl.Count; i++)
                    {
                        FileSystemAccessRule rule = (FileSystemAccessRule)acl[i];
                        if (groups[j].Equals(rule.IdentityReference))
                        {
                            if (AccessControlType.Deny.Equals(rule.AccessControlType))
                            {
                                if (Contains(FileSystemRights.AppendData, rule))
                                {
                                    denyAppendData = true;
                                }
                                    
                                if (Contains(FileSystemRights.ChangePermissions, rule))
                                {
                                    denyChangePermissions = true;
                                }
                                    
                                if (Contains(FileSystemRights.CreateDirectories, rule))
                                {
                                    denyCreateDirectories = true;
                                }
                                    
                                if (Contains(FileSystemRights.CreateFiles, rule))
                                {
                                    denyCreateFiles = true;
                                }
                                    
                                if (Contains(FileSystemRights.Delete, rule))
                                {
                                    denyDelete = true;
                                }
                                    
                                if (Contains(FileSystemRights.DeleteSubdirectoriesAndFiles, rule))
                                {
                                    denyDeleteSubdirectoriesAndFiles = true;
                                }
                                    
                                if (Contains(FileSystemRights.ExecuteFile, rule))
                                {
                                    denyExecuteFile = true;
                                }
                                    
                                if (Contains(FileSystemRights.FullControl, rule))
                                {
                                    denyFullControl = true;
                                }
                                    
                                if (Contains(FileSystemRights.ListDirectory, rule))
                                {
                                    denyListDirectory = true;
                                }
                                    
                                if (Contains(FileSystemRights.Modify, rule))
                                {
                                    denyModify = true;
                                }
                                    
                                if (Contains(FileSystemRights.Read, rule))
                                {
                                    denyRead = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadAndExecute, rule))
                                {
                                    denyReadAndExecute = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadAttributes, rule))
                                {
                                    denyReadAttributes = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadData, rule))
                                {
                                    denyReadData = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadExtendedAttributes, rule))
                                {
                                    denyReadExtendedAttributes = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadPermissions, rule))
                                {
                                    denyReadPermissions = true;
                                }
                                    
                                if (Contains(FileSystemRights.Synchronize, rule))
                                {
                                    denySynchronize = true;
                                }
                                    
                                if (Contains(FileSystemRights.TakeOwnership, rule))
                                {
                                    denyTakeOwnership = true;
                                }
                                    
                                if (Contains(FileSystemRights.Traverse, rule))
                                {
                                    denyTraverse = true;
                                }
                                    
                                if (Contains(FileSystemRights.Write, rule))
                                {
                                    denyWrite = true;
                                }
                                    
                                if (Contains(FileSystemRights.WriteAttributes, rule))
                                {
                                    denyWriteAttributes = true;
                                }
                                    
                                if (Contains(FileSystemRights.WriteData, rule))
                                {
                                    denyWriteData = true;
                                }
                                    
                                if (Contains(FileSystemRights.WriteExtendedAttributes, rule))
                                {
                                    denyWriteExtendedAttributes = true;
                                }
                            }
                            else if (AccessControlType.Allow.Equals(rule.AccessControlType))
                            {
                                if (Contains(FileSystemRights.AppendData, rule))
                                {
                                    allowAppendData = true;
                                }
                                    
                                if (Contains(FileSystemRights.ChangePermissions, rule))
                                {
                                    allowChangePermissions = true;
                                }
                                    
                                if (Contains(FileSystemRights.CreateDirectories, rule))
                                {
                                    allowCreateDirectories = true;
                                }
                                    
                                if (Contains(FileSystemRights.CreateFiles, rule))
                                {
                                    allowCreateFiles = true;
                                }
                                    
                                if (Contains(FileSystemRights.Delete, rule))
                                {
                                    allowDelete = true;
                                }
                                    
                                if (Contains(FileSystemRights.DeleteSubdirectoriesAndFiles, rule))
                                {
                                    allowDeleteSubdirectoriesAndFiles = true;
                                }
                                    
                                if (Contains(FileSystemRights.ExecuteFile, rule))
                                {
                                    allowExecuteFile = true;
                                }
                                    
                                if (Contains(FileSystemRights.FullControl, rule))
                                {
                                    allowFullControl = true;
                                }
                                    
                                if (Contains(FileSystemRights.ListDirectory, rule))
                                {
                                    allowListDirectory = true;
                                }
                                    
                                if (Contains(FileSystemRights.Modify, rule))
                                {
                                    allowModify = true;
                                }
                                    
                                if (Contains(FileSystemRights.Read, rule))
                                {
                                    allowRead = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadAndExecute, rule))
                                {
                                    allowReadAndExecute = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadAttributes, rule))
                                {
                                    allowReadAttributes = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadData, rule))
                                {
                                    allowReadData = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadExtendedAttributes, rule))
                                {
                                    allowReadExtendedAttributes = true;
                                }
                                    
                                if (Contains(FileSystemRights.ReadPermissions, rule))
                                {
                                    allowReadPermissions = true;
                                }
                                    
                                if (Contains(FileSystemRights.Synchronize, rule))
                                {
                                    allowSynchronize = true;
                                }
                                    
                                if (Contains(FileSystemRights.TakeOwnership, rule))
                                {
                                    allowTakeOwnership = true;
                                }
                                    
                                if (Contains(FileSystemRights.Traverse, rule))
                                {
                                    allowTraverse = true;
                                }
                                    
                                if (Contains(FileSystemRights.Write, rule))
                                {
                                    allowWrite = true;
                                }
                                    
                                if (Contains(FileSystemRights.WriteAttributes, rule))
                                {
                                    allowWriteAttributes = true;
                                }
                                    
                                if (Contains(FileSystemRights.WriteData, rule))
                                {
                                    allowWriteData = true;
                                }
                                    
                                if (Contains(FileSystemRights.WriteExtendedAttributes,rule))
                                {
                                    allowWriteExtendedAttributes = true;
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception e)
            {
                //Deal with IO exceptions if you want
                throw new GenericException("An error occured!", e);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Query if this object contains the given right. </summary>
        ///
        /// <param name="right">    The right. </param>
        /// <param name="rule">     The rule. </param>
        ///
        /// <returns>   True if the object is in this collection, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Contains(FileSystemRights right, FileSystemAccessRule rule)
        {
            return (((int)right & (int)rule.FileSystemRights) == (int)right);
        }
    }
}
