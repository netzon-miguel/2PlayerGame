using System.Configuration;

namespace _2PlayerGame
{
    public static class ApplicationSettings
    {
        public static string WelcomeText
        {
            get
            {
                return ConfigurationManager.AppSettings[@"WelcomeText"] ?? @"";
            }
        }
        public static string NameText
        {
            get
            {
                return ConfigurationManager.AppSettings[@"NameText"] ?? @"";
            }
        }
        public static string WeaponChoices
        {
            get
            {
                return ConfigurationManager.AppSettings[@"WeaponChoices"] ?? @"";
            }
        }
        public static string ArmorChoices
        {
            get
            {
                return ConfigurationManager.AppSettings[@"ArmorChoices"] ?? @"";
            }
        }
        public static string BattleInfoText
        {
            get
            {
                return ConfigurationManager.AppSettings[@"BattleInfoText"] ?? @"";
            }
        }
        public static string ActionChoose
        {
            get
            {
                return ConfigurationManager.AppSettings[@"ActionChoose"] ?? @"";
            }
        }
        public static string CoinTossInfo_Pick
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_Pick"] ?? @"";
            }
        }
        public static string CoinTossInfo_PickInfo
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_PickInfo"] ??
                                                        @"";
            }
        }
        public static string CoinTossInfo_First
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_First"] ?? @"";
            }
        }
        public static string CoinTossInfo_Second
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_Second"] ?? @"";
            }
        }
        public static string CoinTossInfo_P1Win
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_P1Win"] ?? @"";
            }
        }
        public static string CoinTossInfo_P2Win
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_P2Win"] ?? @"";
            }
        }
        public static string CoinTossInfo_Goodbye
        {
            get
            {
                return ConfigurationManager.AppSettings[@"CoinTossInfo_Goodbye"] ??
                                                        @"";
            }
        }
        public static string ActionDodgePrompt
        {
            get
            {
                return ConfigurationManager.AppSettings[@"ActionDodgePrompt"] ?? @"";
            }
        }
        public static string AddEnchantmentPrompt
        {
            get
            {
                return ConfigurationManager.AppSettings[@"AddEnchantmentPrompt"] ?? @"";
            }
        }
        public static string Guard
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Guard"] ?? @"";
            }
        }
        public static string Buckler
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Buckler"] ?? @"";
            }
        }
        public static string Shield
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Shield"] ?? @"";
            }
        }
        public static string ThornShield
        {
            get
            {
                return ConfigurationManager.AppSettings[@"ThornShield"] ?? @"";
            }
        }
        public static string Knife
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Knife"] ?? @"";
            }
        }
        public static string Sword
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Sword"] ?? @"";
            }
        }
        public static string Blade
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Blade"] ?? @"";
            }
        }
        public static string Katana
        {
            get
            {
                return ConfigurationManager.AppSettings[@"Katana"] ?? @"";
            }
        }
        
    }
}
