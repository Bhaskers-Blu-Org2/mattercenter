// <copyright file="GlobalSuppressions.cs" company="Microsoft">
//     Copyright (c) . All rights reserved.
// </copyright>
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.TermStoreOperations.#GetClientDetails(Microsoft.SharePoint.Client.ClientRuntimeContext,System.String,System.String,System.String,System.String)", Justification = "Exception details have been captured in log")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ExcelOperations.#ReadRow(DocumentFormat.OpenXml.Spreadsheet.Row,DocumentFormat.OpenXml.Packaging.WorkbookPart)", Justification = "Exception details have been captured in log")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ExcelOperations.#ReadSheet(System.String,System.String)", Justification = "Exception details have been captured in log")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ExcelOperations.#ReadFromExcel(System.String,System.String)", Justification = "Exception details have been captured in log")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ConfigureSharePointContext.#ConfigureClientContext(System.String,System.String,System.String,System.Boolean)", Justification = "URL is passed as string, not URI")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.Client.#ClientUrl", Justification = "URL is passed as string, not URI")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.TermStoreOperations.#GetClientDetails(Microsoft.SharePoint.Client.ClientContext,System.String,System.String,System.String,System.String)", Justification = "Cannot use base type")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.TermStoreOperations.#GetClientDetails(Microsoft.SharePoint.Client.ClientContext,System.String,System.String,System.String,System.String)", Justification = "Exception message is logged")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ConfigureSharePointContext.#ConfigureClientContext(System.String,System.String,System.String,System.Boolean)", Justification = "URL is passed as string, not URI")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ClientTermSets.#ClientTerms", Justification = "It cannot be read-only as it is set based upon term store")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Legal.MatterCenter.Common.ExcelOperations.#ReadSheet(System.String,System.String)", Justification = "Required to maintain list of Specific List of Users (Blocked Users, Added Users)")]