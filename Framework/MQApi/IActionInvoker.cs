﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQApi
{
    public interface IActionInvoker
    {
        void InvokeAction(ControllerContext controllerContext, String actionName);
    }
}
