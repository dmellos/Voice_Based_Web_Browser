Imports System.Runtime.InteropServices
Imports System.Convert
Module Module1

    Public Const ERROR_CACHE_FIND_FAIL As Integer = 0
    Public Const ERROR_CACHE_FIND_SUCCESS As Integer = 1
    Public Const ERROR_FILE_NOT_FOUND As Integer = 2
    Public Const ERROR_ACCESS_DENIED As Integer = 5
    Public Const ERROR_INSUFFICIENT_BUFFER As Integer = 122
    Public Const MAX_PATH As Integer = 260
    Public Const MAX_CACHE_ENTRY_INFO_SIZE As Integer = 4096

    Public Const LMEM_FIXED As Integer = &H0S
    Public Const LMEM_ZEROINIT As Integer = &H40S
    Public Const LPTR As Integer = (LMEM_FIXED Or LMEM_ZEROINIT)

    Public Const NORMAL_CACHE_ENTRY As Long = 2097153
    Public Const EDITED_CACHE_ENTRY As Integer = &H8S
    Public Const TRACK_OFFLINE_CACHE_ENTRY As Integer = &H10S
    Public Const TRACK_ONLINE_CACHE_ENTRY As Integer = &H20S
    Public Const STICKY_CACHE_ENTRY As Integer = &H40S
    Public Const SPARSE_CACHE_ENTRY As Integer = &H10000
    Public Const COOKIE_CACHE_ENTRY As Integer = &H100000
    Public Const URLHISTORY_CACHE_ENTRY As Integer = &H200000
    Public Const URLCACHE_FIND_DEFAULT_FILTER As Integer = NORMAL_CACHE_ENTRY Or COOKIE_CACHE_ENTRY Or URLHISTORY_CACHE_ENTRY Or TRACK_OFFLINE_CACHE_ENTRY Or TRACK_ONLINE_CACHE_ENTRY Or STICKY_CACHE_ENTRY

    Public Function delurlcache(ByVal xurl As String)
        'Indicates that all of the cache groups in the user's system should be enumerated
        Const CACHEGROUP_SEARCH_ALL As Long = &H0
        'Indicates that all of the cache entries that are associated with the cache group should be deleted,
        'unless the entry belongs to another cache group.
        Const CACHEGROUP_FLAG_FLUSHURL_ONDELETE As Long = &H2
        'File not found.
        Const ERROR_FILE_NOT_FOUND As Long = &H2
        'No more items have been found.
        Const ERROR_NO_MORE_ITEMS As Long = 259
        'Pointer to a GROUPID variable
        Dim groupId As Long = 0
        Dim ldate As Date
        Dim icei As Class1.INTERNET_CACHE_ENTRY_INFOA

        'Local variables
        Dim cacheEntryInfoBufferSizeInitial As Integer = 0
        Dim cacheEntryInfoBufferSize As Integer = 0
        Dim cacheEntryInfoBuffer As IntPtr = IntPtr.Zero
        Dim internetCacheEntry As Class1.INTERNET_CACHE_ENTRY_INFOA
        Dim enumHandle As IntPtr = IntPtr.Zero
        Dim returnValue As Boolean = False



        enumHandle = Class1.FindFirstUrlCacheGroup(0, CACHEGROUP_SEARCH_ALL, IntPtr.Zero, 0, groupId, IntPtr.Zero)
        'If there are no items in the Cache, you are finished.
        If (Not enumHandle.Equals(IntPtr.Zero) And ERROR_NO_MORE_ITEMS.Equals(Marshal.GetLastWin32Error)) Then
            Exit Function
        End If

        'Loop through Cache Group.


        enumHandle = Class1.FindFirstUrlCacheEntry(vbNull, IntPtr.Zero, cacheEntryInfoBufferSizeInitial)

        If (Not enumHandle.Equals(IntPtr.Zero) And ERROR_NO_MORE_ITEMS.Equals(Marshal.GetLastWin32Error())) Then
            Exit Function
        End If

        cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial
        cacheEntryInfoBuffer = Marshal.AllocHGlobal(cacheEntryInfoBufferSize)
        enumHandle = Class1.FindFirstUrlCacheEntry(vbNull, cacheEntryInfoBuffer, cacheEntryInfoBufferSizeInitial)

        While (True)
            internetCacheEntry = CType(Marshal.PtrToStructure(cacheEntryInfoBuffer, GetType(Class1.INTERNET_CACHE_ENTRY_INFOA)), Class1.INTERNET_CACHE_ENTRY_INFOA)
            cacheEntryInfoBufferSizeInitial = cacheEntryInfoBufferSize
            Dim fsourceurlname As String = Marshal.PtrToStringAnsi(internetCacheEntry.lpszSourceUrlName)

            If fsourceurlname = xurl Then

                returnValue = Class1.DeleteUrlCacheEntry(internetCacheEntry.lpszSourceUrlName)
            End If

mm:
            returnValue = Class1.FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, cacheEntryInfoBufferSizeInitial)
            If (Not returnValue And ERROR_NO_MORE_ITEMS.Equals(Marshal.GetLastWin32Error())) Then
                Exit While
            End If

            If (Not returnValue And cacheEntryInfoBufferSizeInitial > cacheEntryInfoBufferSize) Then

                cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial
                Dim tempIntPtr As New IntPtr(cacheEntryInfoBufferSize)
                cacheEntryInfoBuffer = Marshal.ReAllocHGlobal(cacheEntryInfoBuffer, tempIntPtr)
                returnValue = Class1.FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, cacheEntryInfoBufferSizeInitial)
            End If

        End While
        Marshal.FreeHGlobal(cacheEntryInfoBuffer)
    End Function
    Public Function GetURLCache(ByVal lview As ListView, ByVal sdate As Date, ByVal type As String) As Object
        'Indicates that all of the cache groups in the user's system should be enumerated
        Const CACHEGROUP_SEARCH_ALL As Long = &H0
        'Indicates that all of the cache entries that are associated with the cache group should be deleted,
        'unless the entry belongs to another cache group.
        Const CACHEGROUP_FLAG_FLUSHURL_ONDELETE As Long = &H2
        'File not found.
        Const ERROR_FILE_NOT_FOUND As Long = &H2
        'No more items have been found.
        Const ERROR_NO_MORE_ITEMS As Long = 259
        'Pointer to a GROUPID variable
        Dim groupId As Long = 0
        Dim ldate As Date
        Dim icei As Class1.INTERNET_CACHE_ENTRY_INFOA
        lview.Items.Clear()
        'Local variables
        Dim cacheEntryInfoBufferSizeInitial As Integer = 0
        Dim cacheEntryInfoBufferSize As Integer = 0
        Dim cacheEntryInfoBuffer As IntPtr = IntPtr.Zero
        Dim internetCacheEntry As Class1.INTERNET_CACHE_ENTRY_INFOA
        Dim enumHandle As IntPtr = IntPtr.Zero
        Dim returnValue As Boolean = False



        enumHandle = Class1.FindFirstUrlCacheGroup(0, CACHEGROUP_SEARCH_ALL, IntPtr.Zero, 0, groupId, IntPtr.Zero)
        'If there are no items in the Cache, you are finished.
        If (Not enumHandle.Equals(IntPtr.Zero) And ERROR_NO_MORE_ITEMS.Equals(Marshal.GetLastWin32Error)) Then
            Exit Function
        End If

        'Loop through Cache Group.


        enumHandle = Class1.FindFirstUrlCacheEntry(vbNull, IntPtr.Zero, cacheEntryInfoBufferSizeInitial)

        If (Not enumHandle.Equals(IntPtr.Zero) And ERROR_NO_MORE_ITEMS.Equals(Marshal.GetLastWin32Error())) Then
            Exit Function
        End If

        cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial
        cacheEntryInfoBuffer = Marshal.AllocHGlobal(cacheEntryInfoBufferSize)
        enumHandle = Class1.FindFirstUrlCacheEntry(vbNull, cacheEntryInfoBuffer, cacheEntryInfoBufferSizeInitial)

        While (True)
            internetCacheEntry = CType(Marshal.PtrToStructure(cacheEntryInfoBuffer, GetType(Class1.INTERNET_CACHE_ENTRY_INFOA)), Class1.INTERNET_CACHE_ENTRY_INFOA)
            cacheEntryInfoBufferSizeInitial = cacheEntryInfoBufferSize
            '' returnValue = Class1.DeleteUrlCacheEntry(internetCacheEntry.lpszSourceUrlName)


            Dim fsourceurlname As String = Marshal.PtrToStringAnsi(internetCacheEntry.lpszSourceUrlName)
            Dim flastaccessdate As String = Class1.FileTime2SystemTime(internetCacheEntry.LastAccessTime)
            Dim ftype As String = internetCacheEntry.CacheEntryType.ToString
            Dim surl As String = Marshal.PtrToStringAnsi(internetCacheEntry.lpszLocalFileName)
            Dim fextension As String = Marshal.PtrToStringAnsi(internetCacheEntry.lpszFileExtension)
            Dim fheaderinfo As String = Marshal.PtrToStringAnsi(internetCacheEntry.lpHeaderInfo)
            Dim fhitrate As String = internetCacheEntry.dwHitRate.ToString
            Dim flastmodifiedtime As String = Class1.FileTime2SystemTime(internetCacheEntry.LastModifiedTime)
            Dim fLastSyncTime As String = Class1.FileTime2SystemTime(internetCacheEntry.LastSyncTime)

            Dim fUseCount As String = internetCacheEntry.dwUseCount.ToString
            If sdate = Format(flastaccessdate, "short date") Then
                If ftype = type And type = "2097153" Then

                    AddData(lview, fsourceurlname, flastaccessdate, ftype, surl, fextension, fheaderinfo, fhitrate, flastmodifiedtime, fLastSyncTime, fUseCount)

                    GoTo mm
                ElseIf ftype = type And type = "1048577" Then
                    AddData(lview, fsourceurlname, flastaccessdate, ftype, surl, fextension, fheaderinfo, fhitrate, flastmodifiedtime, fLastSyncTime, fUseCount)
                    GoTo mm
                ElseIf type = 0 And ftype <> "2097153" And ftype <> "1048577" Then
                    AddData(lview, fsourceurlname, flastaccessdate, ftype, surl, fextension, fheaderinfo, fhitrate, flastmodifiedtime, fLastSyncTime, fUseCount)
                End If

            End If



mm:
            returnValue = Class1.FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, cacheEntryInfoBufferSizeInitial)
            If (Not returnValue And ERROR_NO_MORE_ITEMS.Equals(Marshal.GetLastWin32Error())) Then
                Exit While
            End If

            If (Not returnValue And cacheEntryInfoBufferSizeInitial > cacheEntryInfoBufferSize) Then

                cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial
                Dim tempIntPtr As New IntPtr(cacheEntryInfoBufferSize)
                cacheEntryInfoBuffer = Marshal.ReAllocHGlobal(cacheEntryInfoBuffer, tempIntPtr)
                returnValue = Class1.FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, cacheEntryInfoBufferSizeInitial)
            End If

        End While
        Marshal.FreeHGlobal(cacheEntryInfoBuffer)


    End Function
    Public Sub AddData(ByVal lview As ListView, ByVal fsourceurlname As String, ByVal flastaccessdate As String, ByVal ftype As String, ByVal surl As String, ByVal fextension As String, ByVal fheaderinfo As String, ByVal fhitrate As String, ByVal flastmodifiedtime As String, ByVal fLastSyncTime As String, ByVal fUseCount As String)


        Dim str(10) As String
        Dim itm As ListViewItem
        str(0) = fsourceurlname
        str(1) = flastaccessdate
        str(2) = fhitrate
        str(3) = flastmodifiedtime
        str(4) = fLastSyncTime

        str(5) = fUseCount
        str(6) = surl
        str(7) = fextension
        str(8) = fheaderinfo
        str(9) = ftype

        itm = New ListViewItem(str)
        lview.Items.Add(itm)


    End Sub
End Module

