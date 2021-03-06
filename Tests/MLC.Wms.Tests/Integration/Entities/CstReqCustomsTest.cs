﻿using NUnit.Framework;
using wmsMLC.Business.Objects;

namespace MLC.Wms.Tests.Integration.Entities
{
    [TestFixture]
    public class CstReqCustomsTest : BaseEntityTest<CstReqCustoms>
    {
        public const decimal ExistsItem1Code = -1;
        public const decimal ExistsItem2Code = -2;

        public override void TestFixtureSetUp()
        {
            base.TestFixtureSetUp();

            SimpleChangePropertyName = "REQCUSTOMSCONTRACT";
        }

        protected override void FillRequiredFields(CstReqCustoms entity)
        {
            base.FillRequiredFields(entity);
            dynamic obj = entity.AsDynamic();

            obj.REQCUSTOMSCONTRACT = "TestCintract";
        }
    }
}
