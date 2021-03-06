﻿using wmsMLC.Business.Objects;
using wmsMLC.DCL.General.ViewModels;
using wmsMLC.DCL.Main.Views;
using wmsMLC.General.PL.WPF.Views;

namespace wmsMLC.DCL.Content.ViewModels
{
    [View(typeof(ObjectTreeView))]
    public class CustomParamTreeViewModel : ObjectTreeViewModelBase<CustomParam>
    {
        public CustomParamTreeViewModel()
        {
            KeyPropertyName = new CustomParam().GetPrimaryKeyPropertyName();
            ParentIdPropertyName = CustomParam.CustomParamParentPropertyName.ToUpper();
        }
    }
}