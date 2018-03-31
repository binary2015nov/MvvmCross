﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;

using AppKit;
using MvvmCross.Base;
using MvvmCross.Exceptions;

namespace MvvmCross.Platforms.Mac.Views
{
    public abstract class MvxMacUIThreadDispatcher
        : MvxMainThreadDispatcher
    {
        private readonly SynchronizationContext _uiSynchronizationContext;

        protected MvxMacUIThreadDispatcher()
        {
            _uiSynchronizationContext = SynchronizationContext.Current;
            if (_uiSynchronizationContext == null)
                throw new MvxException("SynchronizationContext must not be null - check to make sure Dispatcher is created on UI thread");
        }

        public bool RequestMainThreadAction(Action action,
            bool maskExceptions = true)
        {
            if (_uiSynchronizationContext == SynchronizationContext.Current)
                action();
            else
                NSApplication.SharedApplication.BeginInvokeOnMainThread(() =>
                {
                    ExceptionMaskedAction(action, maskExceptions);
                });
            return true;
        }
    }
}
