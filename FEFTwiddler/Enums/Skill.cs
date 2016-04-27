﻿namespace FEFTwiddler.Enums
{
    public enum Skill : byte
    {
        None = 0x00,
        HPPlus5 = 0x01,
        StrengthPlus2 = 0x02,
        MagicPlus2 = 0x03,
        SkillPlus2 = 0x04,
        SpeedPlus2 = 0x05,
        LuckPlus4 = 0x06,
        DefensePlus2 = 0x07,
        ResistancePlus2 = 0x08,
        MovementPlus1 = 0x09,
        DraconicHex = 0x0A,
        SealStrength = 0x0B,
        SealMagic = 0x0C,
        SealSpeed = 0x0D,
        SealDefense = 0x0E,
        SealResistance = 0x0F,
        RallyStrength = 0x10,
        RallyMagic = 0x11,
        RallySkill = 0x12,
        RallySpeed = 0x13,
        RallyLuck = 0x14,
        RallyDefense = 0x15,
        RallyResistance = 0x16,
        RallyMovement = 0x17,
        InspiringSong = 0x18,
        Lethality = 0x19,
        Aether = 0x1A,
        Astra = 0x1B,
        DragonFang = 0x1C,
        Sol = 0x1D,
        Luna = 0x1E,
        RendHeaven = 0x1F,
        Vengeance = 0x20,
        Pavise = 0x21,
        Aegis = 0x22,
        DragonWard = 0x23,
        Miracle = 0x24,
        Counter = 0x25,
        MagicCounter = 0x26,
        Vantage = 0x27,
        Beastbane = 0x28,
        Golembane = 0x29,
        NohrianTrust = 0x2A,
        HoshidanUnity = 0x2B,
        Shelter = 0x2C,
        Shove = 0x2D,
        Lunge = 0x2E,
        Swap = 0x2F,
        Replicate = 0x30,
        QuickDraw = 0x31,
        StrongRiposte = 0x32,
        ElbowRoom = 0x33,
        NaturalCover = 0x34,
        Evenhanded = 0x35,
        OddShaped = 0x36,
        LifeAndDeath = 0x37,
        Spendthrift = 0x38,
        DuelistsBlow = 0x39,
        DartingBlow = 0x3A,
        DeathBlow = 0x3B,
        CertainBlow = 0x3C,
        ArmoredBlow = 0x3D,
        WardingBlow = 0x3E,
        Trample = 0x3F,
        WaryFighter = 0x40,
        Swordfaire = 0x41,
        Lancefaire = 0x42,
        Axefaire = 0x43,
        Shurikenfaire = 0x44,
        Bowfaire = 0x45,
        Tomefaire = 0x46,
        Defender = 0x47, // todo
        Charm = 0x48, // todo
        Gentilhomme = 0x49,
        Demoiselle = 0x4A,
        Inspiration = 0x4B,
        MaleficAura = 0x4C,
        VoiceOfPeace = 0x4D,
        ForeignPrincess = 0x4E,
        Swordbreaker = 0x4F,
        Lancebreaker = 0x50,
        Axebreaker = 0x51,
        Shurikenbreaker = 0x52,
        Bowbreaker = 0x53,
        Tomebreaker = 0x54,
        Gamble = 0x55,
        Underdog = 0x56,
        Lucky7 = 0x57,
        AirSuperiority = 0x58,
        Heartseeker = 0x59,
        Quixotic = 0x5A,
        GoodFortune = 0x5B,
        Relief = 0x5C,
        Camaraderie = 0x5D,
        Renewal = 0x5E,
        EvenBetter = 0x5F,
        BetterOdds = 0x60,
        Amaterasu = 0x61,
        Lifetaker = 0x62,
        PotentPotion = 0x63,
        LiveToServe = 0x64,
        PoisonStrike = 0x65,
        SavageBlow = 0x66,
        GrislyWound = 0x67,
        SalvageBlow = 0x68,
        Profiteer = 0x69,
        Nobility = 0x6A,
        FutureSight = 0x6B,
        Aptitude = 0x6C,
        QuickSalve = 0x6D,
        Galeforce = 0x6E,
        Pass = 0x6F,
        Locktouch = 0x70,
        Brynhildr = 0x71, // todo?
        Dragonskin = 0x72, // todo?
        DivineShield = 0x73,
        HitAvoidPlus10 = 0x74,
        HitAvoidPlus20 = 0x75,
        ResistStatus = 0x76,
        ImmuneStatus = 0x77,
        BoldStance = 0x78,
        PointBlank = 0x79,
        WingedShield = 0x7A,
        VoidCurse = 0x7B,
        SelfDestruct = 0x7C,
        StaffSavant = 0x7D,
        Immobilize = 0x7E,
        InevitableEnd = 0x7F,
        EvenKeel = 0x80,
        IronWill = 0x81,
        Clarity = 0x82,
        Aggressor = 0x83,
        DualStriker = 0x84,
        Awakening = 0x85,
        TacticalAdvice = 0x86,
        Solidarity = 0x87,
        Ignis = 0x88,
        RallySpectrum = 0x89,
        Paragon = 0x8A,
        BeastShield = 0x8B,
        ArmorShield = 0x8C,
        Shadowgift = 0x8D,
        StrengthTaker = 0x8E,
        MagicTaker = 0x8F,
        SkillTaker = 0x90,
        SpeedTaker = 0x91,
        LuckTaker = 0x92,
        DefenseTaker = 0x93,
        ResistanceTaker = 0x94,
        Survey = 0x95,
        OpportunityShot = 0x96,
        RifledBarrel = 0x97,
        Surefooted = 0x98,
        WitchsBrew = 0x99,
        Warp = 0x9A,
        ToxicBrew = 0x9B,
        DancingBlade = 0x9C,
        DualGuardsman = 0x9D,
        HeavyBlade = 0x9E,
        VeteranIntuition = 0x9F,
        // Personal skills
        Supportive = 0xA0,
        ForcefulPartner = 0xA1,
        DevotedPartner = 0xA2,
        EvasivePartner = 0xA3,
        FieryBlood = 0xA4,
        MiraculousSave = 0xA5,
        HealingDescant = 0xA6,
        QuietStrength = 0xA7,
        FearsomeBlow = 0xA8,
        Perfectionist = 0xA9,
        VowOfFriendship = 0xAA,
        Pyrotechnics = 0xAB,
        Capture = 0xAC,
        RallyingCry = 0xAD,
        DivineRetribution = 0xAE,
        Optimistic = 0xAF,
        Pride = 0xB0,
        NohrEnmity = 0xB1,
        TripleThreat = 0xB2,
        Competitive = 0xB3,
        ShurikenMastery = 0xB4,
        MorbidCelebration = 0xB5,
        Reciprocity = 0xB6,
        Bushido = 0xB7,
        InExtremis = 0xB8,
        Highwayman = 0xB9,
        LilysPoise = 0xBA,
        Misfortunate = 0xBB,
        Puissance = 0xBC,
        AchingBlood = 0xBD,
        Kidnap = 0xBE,
        Countercurse = 0xBF,
        RosesThorns = 0xC0,
        FierceRival = 0xC1,
        Opportunist = 0xC2,
        FancyFootwork = 0xC3,
        Bloodthirst = 0xC4,
        FierceMien = 0xC5,
        Unmask = 0xC6,
        Pragmatic = 0xC7,
        Collector = 0xC8,
        Chivalry = 0xC9,
        Peacebringer = 0xCA,
        WindDisciple = 0xCB,
        Perspicacious = 0xCC,
        IcyBlood = 0xCD,
        Forager = 0xCE,
        DraconicHeir = 0xCF,
        BornSteward = 0xD0,
        PerfectPitch = 0xD1,
        Mischievous = 0xD2,
        LuckyCharm = 0xD3,
        NobleCause = 0xD4,
        Optimist = 0xD5,
        SweetTooth = 0xD6,
        Playthings = 0xD7,
        Calm = 0xD8,
        Haiku = 0xD9,
        Prodigy = 0xDA,
        Vendetta = 0xDB,
        Gallant = 0xDC,
        FierceCounter = 0xDD,
        GuardedBravery = 0xDE,
        Scavenge = 0xDF,
        FortunateSon = 0xE0,
        Bibliophile = 0xE1,
        Sisterhood = 0xE2,
        Daydream = 0xE3,
        MakeAKilling = 0xE4
    }
}
