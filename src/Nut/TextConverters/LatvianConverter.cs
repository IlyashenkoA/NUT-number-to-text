using System;
using Nut.Models;

namespace Nut.TextConverters
{
    public sealed class LatvianConverter : BaseConverter
    {
        private static readonly Lazy<LatvianConverter> Lazy = new Lazy<LatvianConverter>(() => new LatvianConverter());
        public static LatvianConverter Instance => Lazy.Value;

        public override string CultureName => Culture.LatvianLV;

        public LatvianConverter()
        {
            Initialize();
        }

        private void Initialize()
        {
            NumberTexts.Add(0, new[] { "nulle" });
            NumberTexts.Add(1, new[] { "viens" });
            NumberTexts.Add(2, new[] { "divi" });
            NumberTexts.Add(3, new[] { "trīs" });
            NumberTexts.Add(4, new[] { "četri" });
            NumberTexts.Add(5, new[] { "pieci" });
            NumberTexts.Add(6, new[] { "seši" });
            NumberTexts.Add(7, new[] { "septiņi" });
            NumberTexts.Add(8, new[] { "astoņi" });
            NumberTexts.Add(9, new[] { "deviņi" });
            NumberTexts.Add(10, new[] { "desmit" });
            NumberTexts.Add(11, new[] { "vienpadsmit" });
            NumberTexts.Add(12, new[] { "divpadsmit" });
            NumberTexts.Add(13, new[] { "trīspadsmit" });
            NumberTexts.Add(14, new[] { "četrpadsmit" });
            NumberTexts.Add(15, new[] { "piecpadsmit" });
            NumberTexts.Add(16, new[] { "sešpadsmit" });
            NumberTexts.Add(17, new[] { "septiņpadsmit" });
            NumberTexts.Add(18, new[] { "astoņpadsmit" });
            NumberTexts.Add(19, new[] { "deviņpadsmit" });
            NumberTexts.Add(20, new[] { "divdesmit" });
            NumberTexts.Add(30, new[] { "trīsdesmit" });
            NumberTexts.Add(40, new[] { "četrdesmit" });
            NumberTexts.Add(50, new[] { "piecdesmit" });
            NumberTexts.Add(60, new[] { "sešdesmit" });
            NumberTexts.Add(70, new[] { "septiņdesmit" });
            NumberTexts.Add(80, new[] { "astoņdesmit" });
            NumberTexts.Add(90, new[] { "deviņdesmit" });
            NumberTexts.Add(100, new[] { "simts" });

            ScaleTexts.Add(1000000000, new[] { "miljards" });
            ScaleTexts.Add(1000000, new[] { "miljons" });
            ScaleTexts.Add(1000, new[] { "tūkstotis" });
        }

        protected override CurrencyModel GetCurrencyModel(string currency)
        {
            switch (currency)
            {
                case Currency.EUR:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "eiro", "eiro" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "centi", "centi" } }
                    };
                case Currency.USD:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "dolārs", "dolāri" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "centi", "centi" } }
                    };
                case Currency.RUB:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "rublis", "rubļi" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kapeika", "kapeikas" } }
                    };
                case Currency.TRY:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "turku lira", "turku liras" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kurušs", "kuruši" } }
                    };
                case Currency.UAH:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "ukraiņu grivna", "ukraiņu grivnas" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kopijka", "kopijkas", "kopijku" } }
                    };

                case Currency.ETB:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "birs", "birsi" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "cents", "centi" } }
                    };
                case Currency.PLN:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "zlots", "zloti" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "grošs", "groši", "grošu" } }
                    };
                case Currency.BYN:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "Baltkrievijas rublis", "Baltkrievijas rubļi" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kapeika", "kapeikas" } }
                    };
                case Currency.GBP:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "sterliņu mārciņa", "sterliņu mārciņas" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "penss", "pensi" } }
                    };
                case Currency.CAD:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "kanādas dolārs", "kanādas dolāri" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "centi", "centi" } }
                    };
            }

            return null;
        }
    }
}