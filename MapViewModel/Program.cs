using MapViewModel;
using MapViewModel.Services;
using MapViewModel.Validacao.Spe;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;


var app = new ValidacaoApplication();

await app.Iniciar();

/*
string json = @"
{
    ""id"": 1952878,
    ""keycloakId"": ""6683b694-2c0d-40f9-b249-af17cdd53229"",
    ""username"": ""ottipsd"",
    ""email"": ""ottipsd@gmail.com"",
    ""firstName"": ""Otti PSD"",
    ""lastName"": null,
    ""displayName"": null,
    ""ownerBusinessUnit"": ""eem"",
    ""cpf"": ""24810260046"",
    ""rg"": null,
    ""cellPhone"": null,
    ""phone"": null,
    ""birthday"": null,
    ""inheritedId"": ""7F360F52-FFFA-4A0E-9DA4-343CCB461357"",
    ""businessUnit"": {
        ""id"": 2,
        ""name"": ""Escola em Movimento"",
        ""code"": ""EEM"",
        ""partnerIntegrationKeys"": [
            {
                ""id"": 1,
                ""destinyBusinessUnit"": ""studos"",
                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
            }
        ],
        ""realmName"": ""eem"",
        ""businessUnitType"": {
            ""id"": 1,
            ""name"": ""CORE"",
            ""description"": ""CORE""
        }
    },
    ""accounts"": [
        {
            ""id"": 2125382,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7113,
                ""cnpj"": null,
                ""companyName"": ""Unidade Default"",
                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125383,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7115,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Junior"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125384,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7114,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Ambiental"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125388,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7112,
                ""cnpj"": """",
                ""companyName"": ""RP8"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#7"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125385,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7109,
                ""cnpj"": """",
                ""companyName"": ""Colégio Pequeno Príncipe "",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#4"",
                ""inheritedCrmCode"": null,
                ""active"": false,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125386,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7110,
                ""cnpj"": """",
                ""companyName"": ""RP6_Teste_2022"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#5"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125387,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 7111,
                ""cnpj"": """",
                ""companyName"": ""RP7"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#6"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 1301864,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 5038,
                ""cnpj"": null,
                ""companyName"": ""Unidade reprodução teste teste"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 1301862,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 5037,
                ""cnpj"": null,
                ""companyName"": ""Matriz Teste 2809"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 1301863,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 7,
                ""name"": ""Conveniada""
            },
            ""institution"": {
                ""id"": 5036,
                ""cnpj"": null,
                ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125390,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7115,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Junior"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125392,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7109,
                ""cnpj"": """",
                ""companyName"": ""Colégio Pequeno Príncipe "",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#4"",
                ""inheritedCrmCode"": null,
                ""active"": false,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125393,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7110,
                ""cnpj"": """",
                ""companyName"": ""RP6_Teste_2022"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#5"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125394,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7111,
                ""cnpj"": """",
                ""companyName"": ""RP7"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#6"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125395,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7112,
                ""cnpj"": """",
                ""companyName"": ""RP8"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#7"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125389,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7113,
                ""cnpj"": null,
                ""companyName"": ""Unidade Default"",
                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2125391,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 7114,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Ambiental"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 1301867,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 5038,
                ""cnpj"": null,
                ""companyName"": ""Unidade reprodução teste teste"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 1301866,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 5036,
                ""cnpj"": null,
                ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 1301865,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 17,
                ""name"": ""Pedagógico""
            },
            ""institution"": {
                ""id"": 5037,
                ""cnpj"": null,
                ""companyName"": ""Matriz Teste 2809"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            }
        },
        {
            ""id"": 2122704,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7109,
                ""cnpj"": """",
                ""companyName"": ""Colégio Pequeno Príncipe "",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#4"",
                ""inheritedCrmCode"": null,
                ""active"": false,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": []
        },
        {
            ""id"": 2122705,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7110,
                ""cnpj"": """",
                ""companyName"": ""RP6_Teste_2022"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#5"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": []
        },
        {
            ""id"": 2122706,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7111,
                ""cnpj"": """",
                ""companyName"": ""RP7"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#6"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": []
        },
        {
            ""id"": 2122707,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7112,
                ""cnpj"": """",
                ""companyName"": ""RP8"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#7"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": [
                {
                    ""id"": 618791,
                    ""classroom"": {
                        ""id"": 72765,
                        ""name"": ""1ª Série Jose Maria"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#113"",
                        ""shift"": {
                            ""id"": 3,
                            ""name"": ""Noite""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7112,
                            ""cnpj"": """",
                            ""companyName"": ""RP8"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#7"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 629125,
                    ""classroom"": {
                        ""id"": 100172,
                        ""name"": ""2ª Série Jose Maria"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#288"",
                        ""shift"": {
                            ""id"": 3,
                            ""name"": ""Noite""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                }
            ]
        },
        {
            ""id"": 2122701,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7113,
                ""cnpj"": null,
                ""companyName"": ""Unidade Default"",
                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": [
                {
                    ""id"": 618774,
                    ""classroom"": {
                        ""id"": 72548,
                        ""name"": ""AIE_G1"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#98"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 18,
                            ""name"": ""Infantil I"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618775,
                    ""classroom"": {
                        ""id"": 72585,
                        ""name"": ""AIE_G4"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#101"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 3,
                            ""name"": ""Infantil IV"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 671459,
                    ""classroom"": {
                        ""id"": 72654,
                        ""name"": ""4ª Série Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#263"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 8,
                            ""name"": ""4º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618776,
                    ""classroom"": {
                        ""id"": 72787,
                        ""name"": ""1 série A_2023"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#278"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 671460,
                    ""classroom"": {
                        ""id"": 100172,
                        ""name"": ""2ª Série Jose Maria"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#288"",
                        ""shift"": {
                            ""id"": 3,
                            ""name"": ""Noite""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 629136,
                    ""classroom"": {
                        ""id"": 100174,
                        ""name"": ""2 série A_2023"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#289"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 629137,
                    ""classroom"": {
                        ""id"": 100176,
                        ""name"": ""2 série A_2023."",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#290"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 656337,
                    ""classroom"": {
                        ""id"": 100961,
                        ""name"": ""AIE_G4"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#295"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 3,
                            ""name"": ""Infantil IV"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 690097,
                    ""classroom"": {
                        ""id"": 104429,
                        ""name"": ""2ªSÉRIEEM_RP7_2023"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#319"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 692802,
                    ""classroom"": {
                        ""id"": 104755,
                        ""name"": ""2º Ano EF1 - Teste"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#321"",
                        ""shift"": {
                            ""id"": 2,
                            ""name"": ""Tarde""
                        },
                        ""grade"": {
                            ""id"": 6,
                            ""name"": ""2º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 781929,
                    ""classroom"": {
                        ""id"": 116219,
                        ""name"": ""2ª Série EM 2023"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#344"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 827826,
                    ""classroom"": {
                        ""id"": 121352,
                        ""name"": ""1ª Série - 2023"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#363"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 827838,
                    ""classroom"": {
                        ""id"": 121353,
                        ""name"": ""2ª Série - 2023"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#364"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 842781,
                    ""classroom"": {
                        ""id"": 125609,
                        ""name"": ""1ª Série - 2023 A4"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#369"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                }
            ]
        },
        {
            ""id"": 2122703,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7114,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Ambiental"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": []
        },
        {
            ""id"": 2122702,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 7115,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Junior"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": [
                {
                    ""id"": 618778,
                    ""classroom"": {
                        ""id"": 72559,
                        ""name"": ""AIE_G2"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#99"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 1,
                            ""name"": ""Infantil II"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618779,
                    ""classroom"": {
                        ""id"": 72566,
                        ""name"": ""AIE_G3"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#100"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 2,
                            ""name"": ""Infantil III"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618790,
                    ""classroom"": {
                        ""id"": 72597,
                        ""name"": ""AIE_1ANO"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#150"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 5,
                            ""name"": ""1º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618782,
                    ""classroom"": {
                        ""id"": 72644,
                        ""name"": ""3º  Ano Conexão"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#129"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 7,
                            ""name"": ""3º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618784,
                    ""classroom"": {
                        ""id"": 72654,
                        ""name"": ""4ª Série Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#263"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 8,
                            ""name"": ""4º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7113,
                            ""cnpj"": null,
                            ""companyName"": ""Unidade Default"",
                            ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618785,
                    ""classroom"": {
                        ""id"": 72663,
                        ""name"": ""4º Ano Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#134"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 8,
                            ""name"": ""4º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618786,
                    ""classroom"": {
                        ""id"": 72680,
                        ""name"": ""5º Ano Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#138"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 9,
                            ""name"": ""5º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618787,
                    ""classroom"": {
                        ""id"": 72700,
                        ""name"": ""6º  Ano Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#139"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 10,
                            ""name"": ""6º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618788,
                    ""classroom"": {
                        ""id"": 72720,
                        ""name"": ""7º Ano Conexão"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#143"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 11,
                            ""name"": ""7º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618789,
                    ""classroom"": {
                        ""id"": 72730,
                        ""name"": ""8 Ano Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#145"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 12,
                            ""name"": ""8º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618783,
                    ""classroom"": {
                        ""id"": 72761,
                        ""name"": ""AIE_1serie"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#151"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618780,
                    ""classroom"": {
                        ""id"": 72786,
                        ""name"": ""2ª Série Conexão"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#122"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618781,
                    ""classroom"": {
                        ""id"": 72808,
                        ""name"": ""3ª Série Conexão"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#128"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 17,
                            ""name"": ""3ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 618777,
                    ""classroom"": {
                        ""id"": 72818,
                        ""name"": ""AIE_G5 - Certo"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#94"",
                        ""shift"": {
                            ""id"": 4,
                            ""name"": ""Integral""
                        },
                        ""grade"": {
                            ""id"": 4,
                            ""name"": ""Infantil V"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 660972,
                    ""classroom"": {
                        ""id"": 101601,
                        ""name"": ""8º Ano Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#309"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 12,
                            ""name"": ""8º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 718165,
                    ""classroom"": {
                        ""id"": 108357,
                        ""name"": ""AIE_1serie"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#328"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 728606,
                    ""classroom"": {
                        ""id"": 109545,
                        ""name"": ""AIE_1ANO"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#329"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 5,
                            ""name"": ""1º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 783939,
                    ""classroom"": {
                        ""id"": 116459,
                        ""name"": ""3º Série EM"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#345"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 17,
                            ""name"": ""3ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 809610,
                    ""classroom"": {
                        ""id"": 119590,
                        ""name"": ""2º série AEM"",
                        ""active"": false,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#354"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 15,
                            ""name"": ""2ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 810913,
                    ""classroom"": {
                        ""id"": 119703,
                        ""name"": ""4º  Ano Conexão"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#356"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 8,
                            ""name"": ""4º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 7115,
                            ""cnpj"": """",
                            ""companyName"": ""Unidade Positivo Junior"",
                            ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 7108,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Assessoria Positivo"",
                                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                                ""inheritedCrmCode"": ""29101"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                }
            ]
        },
        {
            ""id"": 1300722,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 5037,
                ""cnpj"": null,
                ""companyName"": ""Matriz Teste 2809"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": []
        },
        {
            ""id"": 1300573,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 5038,
                ""cnpj"": null,
                ""companyName"": ""Unidade reprodução teste teste"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": []
        },
        {
            ""id"": 1300356,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 3,
                ""name"": ""Professor""
            },
            ""institution"": {
                ""id"": 5036,
                ""cnpj"": null,
                ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 5035,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Positivo ON SPE 18-005"",
                    ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                    ""inheritedCrmCode"": ""-5"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""classrooms"": [
                {
                    ""id"": 248687,
                    ""classroom"": {
                        ""id"": 47323,
                        ""name"": ""DOR - SPE005 - G5 - Teste"",
                        ""active"": true,
                        ""year"": 2022,
                        ""startDate"": ""2022-01-01"",
                        ""endDate"": ""2022-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#22"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 4,
                            ""name"": ""Infantil V"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 884631,
                    ""classroom"": {
                        ""id"": 47370,
                        ""name"": ""Teste Modelo"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#69"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249643,
                    ""classroom"": {
                        ""id"": 47710,
                        ""name"": ""PSD1EM"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#409"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249644,
                    ""classroom"": {
                        ""id"": 47711,
                        ""name"": ""PSD6EF"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#410"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 10,
                            ""name"": ""6º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249648,
                    ""classroom"": {
                        ""id"": 47712,
                        ""name"": ""PSDG5"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#411"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 4,
                            ""name"": ""Infantil V"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249649,
                    ""classroom"": {
                        ""id"": 47713,
                        ""name"": ""PSD1EF"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#412"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 5,
                            ""name"": ""1º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249710,
                    ""classroom"": {
                        ""id"": 47733,
                        ""name"": ""PSD5EF"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#432"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 9,
                            ""name"": ""5º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 889845,
                    ""classroom"": {
                        ""id"": 47748,
                        ""name"": ""AIE_6ANO"",
                        ""active"": true,
                        ""year"": 2023,
                        ""startDate"": ""2023-01-01"",
                        ""endDate"": ""2023-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#447"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 10,
                            ""name"": ""6º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249773,
                    ""classroom"": {
                        ""id"": 47768,
                        ""name"": ""Turma PSD EM 1_serie"",
                        ""active"": true,
                        ""year"": 2022,
                        ""startDate"": ""2022-01-01"",
                        ""endDate"": ""2022-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#467"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 14,
                            ""name"": ""1ª Série"",
                            ""stage"": {
                                ""id"": 4,
                                ""name"": ""MEDIO"",
                                ""description"": ""Ensino Médio""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249779,
                    ""classroom"": {
                        ""id"": 47769,
                        ""name"": ""Turma PSD EF1 6_Ano"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#468"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 10,
                            ""name"": ""6º Ano"",
                            ""stage"": {
                                ""id"": 3,
                                ""name"": ""FUND_2"",
                                ""description"": ""Ensino Fundamental - Anos Finais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249780,
                    ""classroom"": {
                        ""id"": 47770,
                        ""name"": ""Turma PSD EI G5"",
                        ""active"": true,
                        ""year"": 2022,
                        ""startDate"": ""2022-01-01"",
                        ""endDate"": ""2022-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#469"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 4,
                            ""name"": ""Infantil V"",
                            ""stage"": {
                                ""id"": 1,
                                ""name"": ""INFANTIL"",
                                ""description"": ""Educação Infantil""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249784,
                    ""classroom"": {
                        ""id"": 47771,
                        ""name"": ""Turma PSD EF1 1_Ano"",
                        ""active"": true,
                        ""year"": 2022,
                        ""startDate"": ""2022-01-01"",
                        ""endDate"": ""2022-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#470"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 5,
                            ""name"": ""1º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249785,
                    ""classroom"": {
                        ""id"": 47772,
                        ""name"": ""Turma PSD EF1 5_Ano"",
                        ""active"": true,
                        ""year"": 2022,
                        ""startDate"": ""2022-01-01"",
                        ""endDate"": ""2022-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#471"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 9,
                            ""name"": ""5º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                },
                {
                    ""id"": 249869,
                    ""classroom"": {
                        ""id"": 47803,
                        ""name"": ""Turma teste CS 2021"",
                        ""active"": true,
                        ""year"": 2021,
                        ""startDate"": ""2021-01-01"",
                        ""endDate"": ""2021-12-31"",
                        ""inheritedClassroomCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#502"",
                        ""shift"": {
                            ""id"": 1,
                            ""name"": ""Manhã""
                        },
                        ""grade"": {
                            ""id"": 9,
                            ""name"": ""5º Ano"",
                            ""stage"": {
                                ""id"": 2,
                                ""name"": ""FUND_1"",
                                ""description"": ""Ensino Fundamental - Anos Iniciais""
                            }
                        },
                        ""institution"": {
                            ""id"": 5036,
                            ""cnpj"": null,
                            ""companyName"": ""Escola Positivo ON SPE 18-005 Teste 2809"",
                            ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518#2"",
                            ""inheritedCrmCode"": null,
                            ""active"": true,
                            ""parentInstitution"": {
                                ""id"": 5035,
                                ""cnpj"": ""10.227.585/0001-30"",
                                ""companyName"": ""Escola Positivo ON SPE 18-005"",
                                ""inheritedSchoolCode"": ""21694EC0-88BE-4231-AC2A-392DBF835518"",
                                ""inheritedCrmCode"": ""-5"",
                                ""active"": true,
                                ""parentInstitution"": null,
                                ""businessUnit"": {
                                    ""id"": 2,
                                    ""name"": ""Escola em Movimento"",
                                    ""code"": ""EEM"",
                                    ""partnerIntegrationKeys"": [
                                        {
                                            ""id"": 1,
                                            ""destinyBusinessUnit"": ""studos"",
                                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                        }
                                    ],
                                    ""realmName"": ""eem"",
                                    ""businessUnitType"": {
                                        ""id"": 1,
                                        ""name"": ""CORE"",
                                        ""description"": ""CORE""
                                    }
                                },
                                ""address"": {
                                    ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                                    ""zipcode"": ""30130-160"",
                                    ""region"": """",
                                    ""state"": ""Minas Gerais"",
                                    ""city"": ""Belo Horizonte""
                                }
                            },
                            ""businessUnit"": {
                                ""id"": 2,
                                ""name"": ""Escola em Movimento"",
                                ""code"": ""EEM"",
                                ""partnerIntegrationKeys"": [
                                    {
                                        ""id"": 1,
                                        ""destinyBusinessUnit"": ""studos"",
                                        ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                    }
                                ],
                                ""realmName"": ""eem"",
                                ""businessUnitType"": {
                                    ""id"": 1,
                                    ""name"": ""CORE"",
                                    ""description"": ""CORE""
                                }
                            },
                            ""address"": {
                                ""address"": """",
                                ""zipcode"": """",
                                ""region"": """",
                                ""state"": """",
                                ""city"": """"
                            }
                        }
                    }
                }
            ]
        },
        {
            ""id"": 2123264,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7109,
                ""cnpj"": """",
                ""companyName"": ""Colégio Pequeno Príncipe "",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#4"",
                ""inheritedCrmCode"": null,
                ""active"": false,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": []
        },
        {
            ""id"": 2123265,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7110,
                ""cnpj"": """",
                ""companyName"": ""RP6_Teste_2022"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#5"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": [
                {
                    ""id"": 626932,
                    ""dependent"": {
                        ""id"": 2786527,
                        ""keycloakId"": ""867eb11f-98ec-40e6-a099-869308a19267"",
                        ""username"": ""aluno1em"",
                        ""email"": null,
                        ""firstName"": ""Aluno 1o EM 21"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""4C4A187C-3690-4850-8CC8-3C10B432F070"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 612710,
                    ""dependent"": {
                        ""id"": 2786774,
                        ""keycloakId"": ""0518af0f-8d65-4b39-b894-87e76fe0da79"",
                        ""username"": ""aieem1"",
                        ""email"": ""aie@teste.com.br"",
                        ""firstName"": ""Aluno AIE EM 1"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""3E047757-A057-458E-87E7-6DFB8B49C3C3"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 614017,
                    ""dependent"": {
                        ""id"": 4665462,
                        ""keycloakId"": ""2752ffbc-4367-491a-86ee-a4ce2fe7406a"",
                        ""username"": ""alunolive160123"",
                        ""email"": null,
                        ""firstName"": ""Aluno Live 16-01-23"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""D8CA4CB3-BFE8-4EA9-8906-F584C5E27869"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626711,
                    ""dependent"": {
                        ""id"": 4960840,
                        ""keycloakId"": ""5b86dbb1-bb9b-453e-9661-f4caf835fa15"",
                        ""username"": ""sergiom"",
                        ""email"": ""prof.h.araken@prof.educacao.sp.gov.br"",
                        ""firstName"": ""Sergio Manoel"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""ECFA0407-4A0C-48DF-B97A-60E28894EDC7"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                }
            ]
        },
        {
            ""id"": 2123266,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7111,
                ""cnpj"": """",
                ""companyName"": ""RP7"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#6"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": [
                {
                    ""id"": 626933,
                    ""dependent"": {
                        ""id"": 2786527,
                        ""keycloakId"": ""867eb11f-98ec-40e6-a099-869308a19267"",
                        ""username"": ""aluno1em"",
                        ""email"": null,
                        ""firstName"": ""Aluno 1o EM 21"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""4C4A187C-3690-4850-8CC8-3C10B432F070"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 612711,
                    ""dependent"": {
                        ""id"": 2786774,
                        ""keycloakId"": ""0518af0f-8d65-4b39-b894-87e76fe0da79"",
                        ""username"": ""aieem1"",
                        ""email"": ""aie@teste.com.br"",
                        ""firstName"": ""Aluno AIE EM 1"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""3E047757-A057-458E-87E7-6DFB8B49C3C3"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 614018,
                    ""dependent"": {
                        ""id"": 4665462,
                        ""keycloakId"": ""2752ffbc-4367-491a-86ee-a4ce2fe7406a"",
                        ""username"": ""alunolive160123"",
                        ""email"": null,
                        ""firstName"": ""Aluno Live 16-01-23"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""D8CA4CB3-BFE8-4EA9-8906-F584C5E27869"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626712,
                    ""dependent"": {
                        ""id"": 4960840,
                        ""keycloakId"": ""5b86dbb1-bb9b-453e-9661-f4caf835fa15"",
                        ""username"": ""sergiom"",
                        ""email"": ""prof.h.araken@prof.educacao.sp.gov.br"",
                        ""firstName"": ""Sergio Manoel"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""ECFA0407-4A0C-48DF-B97A-60E28894EDC7"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                }
            ]
        },
        {
            ""id"": 2123267,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7112,
                ""cnpj"": """",
                ""companyName"": ""RP8"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#7"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": [
                {
                    ""id"": 626934,
                    ""dependent"": {
                        ""id"": 2786527,
                        ""keycloakId"": ""867eb11f-98ec-40e6-a099-869308a19267"",
                        ""username"": ""aluno1em"",
                        ""email"": null,
                        ""firstName"": ""Aluno 1o EM 21"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""4C4A187C-3690-4850-8CC8-3C10B432F070"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 612712,
                    ""dependent"": {
                        ""id"": 2786774,
                        ""keycloakId"": ""0518af0f-8d65-4b39-b894-87e76fe0da79"",
                        ""username"": ""aieem1"",
                        ""email"": ""aie@teste.com.br"",
                        ""firstName"": ""Aluno AIE EM 1"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""3E047757-A057-458E-87E7-6DFB8B49C3C3"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 614019,
                    ""dependent"": {
                        ""id"": 4665462,
                        ""keycloakId"": ""2752ffbc-4367-491a-86ee-a4ce2fe7406a"",
                        ""username"": ""alunolive160123"",
                        ""email"": null,
                        ""firstName"": ""Aluno Live 16-01-23"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""D8CA4CB3-BFE8-4EA9-8906-F584C5E27869"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626713,
                    ""dependent"": {
                        ""id"": 4960840,
                        ""keycloakId"": ""5b86dbb1-bb9b-453e-9661-f4caf835fa15"",
                        ""username"": ""sergiom"",
                        ""email"": ""prof.h.araken@prof.educacao.sp.gov.br"",
                        ""firstName"": ""Sergio Manoel"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""ECFA0407-4A0C-48DF-B97A-60E28894EDC7"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                }
            ]
        },
        {
            ""id"": 2123261,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7113,
                ""cnpj"": null,
                ""companyName"": ""Unidade Default"",
                ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B#1"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": [
                {
                    ""id"": 626928,
                    ""dependent"": {
                        ""id"": 2786527,
                        ""keycloakId"": ""867eb11f-98ec-40e6-a099-869308a19267"",
                        ""username"": ""aluno1em"",
                        ""email"": null,
                        ""firstName"": ""Aluno 1o EM 21"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""4C4A187C-3690-4850-8CC8-3C10B432F070"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 612707,
                    ""dependent"": {
                        ""id"": 2786774,
                        ""keycloakId"": ""0518af0f-8d65-4b39-b894-87e76fe0da79"",
                        ""username"": ""aieem1"",
                        ""email"": ""aie@teste.com.br"",
                        ""firstName"": ""Aluno AIE EM 1"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""3E047757-A057-458E-87E7-6DFB8B49C3C3"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626707,
                    ""dependent"": {
                        ""id"": 4665462,
                        ""keycloakId"": ""2752ffbc-4367-491a-86ee-a4ce2fe7406a"",
                        ""username"": ""alunolive160123"",
                        ""email"": null,
                        ""firstName"": ""Aluno Live 16-01-23"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""D8CA4CB3-BFE8-4EA9-8906-F584C5E27869"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626708,
                    ""dependent"": {
                        ""id"": 4960840,
                        ""keycloakId"": ""5b86dbb1-bb9b-453e-9661-f4caf835fa15"",
                        ""username"": ""sergiom"",
                        ""email"": ""prof.h.araken@prof.educacao.sp.gov.br"",
                        ""firstName"": ""Sergio Manoel"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""ECFA0407-4A0C-48DF-B97A-60E28894EDC7"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                }
            ]
        },
        {
            ""id"": 2123263,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7114,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Ambiental"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#3"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": [
                {
                    ""id"": 626931,
                    ""dependent"": {
                        ""id"": 2786527,
                        ""keycloakId"": ""867eb11f-98ec-40e6-a099-869308a19267"",
                        ""username"": ""aluno1em"",
                        ""email"": null,
                        ""firstName"": ""Aluno 1o EM 21"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""4C4A187C-3690-4850-8CC8-3C10B432F070"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 612709,
                    ""dependent"": {
                        ""id"": 2786774,
                        ""keycloakId"": ""0518af0f-8d65-4b39-b894-87e76fe0da79"",
                        ""username"": ""aieem1"",
                        ""email"": ""aie@teste.com.br"",
                        ""firstName"": ""Aluno AIE EM 1"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""3E047757-A057-458E-87E7-6DFB8B49C3C3"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 614016,
                    ""dependent"": {
                        ""id"": 4665462,
                        ""keycloakId"": ""2752ffbc-4367-491a-86ee-a4ce2fe7406a"",
                        ""username"": ""alunolive160123"",
                        ""email"": null,
                        ""firstName"": ""Aluno Live 16-01-23"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""D8CA4CB3-BFE8-4EA9-8906-F584C5E27869"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626710,
                    ""dependent"": {
                        ""id"": 4960840,
                        ""keycloakId"": ""5b86dbb1-bb9b-453e-9661-f4caf835fa15"",
                        ""username"": ""sergiom"",
                        ""email"": ""prof.h.araken@prof.educacao.sp.gov.br"",
                        ""firstName"": ""Sergio Manoel"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""ECFA0407-4A0C-48DF-B97A-60E28894EDC7"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                }
            ]
        },
        {
            ""id"": 2123262,
            ""active"": true,
            ""user"": 1952878,
            ""accessKey"": null,
            ""profile"": {
                ""id"": 18,
                ""name"": ""Responsável""
            },
            ""institution"": {
                ""id"": 7115,
                ""cnpj"": """",
                ""companyName"": ""Unidade Positivo Junior"",
                ""inheritedSchoolCode"": ""903f8603-d9fa-40c6-b9a7-7ab2de7ef84b#2"",
                ""inheritedCrmCode"": null,
                ""active"": true,
                ""parentInstitution"": {
                    ""id"": 7108,
                    ""cnpj"": ""10.227.585/0001-30"",
                    ""companyName"": ""Escola Assessoria Positivo"",
                    ""inheritedSchoolCode"": ""903F8603-D9FA-40C6-B9A7-7AB2DE7EF84B"",
                    ""inheritedCrmCode"": ""29101"",
                    ""active"": true,
                    ""parentInstitution"": null,
                    ""businessUnit"": {
                        ""id"": 2,
                        ""name"": ""Escola em Movimento"",
                        ""code"": ""EEM"",
                        ""partnerIntegrationKeys"": [
                            {
                                ""id"": 1,
                                ""destinyBusinessUnit"": ""studos"",
                                ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                            }
                        ],
                        ""realmName"": ""eem"",
                        ""businessUnitType"": {
                            ""id"": 1,
                            ""name"": ""CORE"",
                            ""description"": ""CORE""
                        }
                    },
                    ""address"": {
                        ""address"": ""Rua alagoas  1162 4 andar Savassi"",
                        ""zipcode"": ""30130-160"",
                        ""region"": """",
                        ""state"": ""Minas Gerais"",
                        ""city"": ""Belo Horizonte""
                    }
                },
                ""businessUnit"": {
                    ""id"": 2,
                    ""name"": ""Escola em Movimento"",
                    ""code"": ""EEM"",
                    ""partnerIntegrationKeys"": [
                        {
                            ""id"": 1,
                            ""destinyBusinessUnit"": ""studos"",
                            ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                        }
                    ],
                    ""realmName"": ""eem"",
                    ""businessUnitType"": {
                        ""id"": 1,
                        ""name"": ""CORE"",
                        ""description"": ""CORE""
                    }
                },
                ""address"": {
                    ""address"": """",
                    ""zipcode"": """",
                    ""region"": """",
                    ""state"": """",
                    ""city"": """"
                }
            },
            ""dependents"": [
                {
                    ""id"": 626930,
                    ""dependent"": {
                        ""id"": 2786527,
                        ""keycloakId"": ""867eb11f-98ec-40e6-a099-869308a19267"",
                        ""username"": ""aluno1em"",
                        ""email"": null,
                        ""firstName"": ""Aluno 1o EM 21"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""4C4A187C-3690-4850-8CC8-3C10B432F070"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 612708,
                    ""dependent"": {
                        ""id"": 2786774,
                        ""keycloakId"": ""0518af0f-8d65-4b39-b894-87e76fe0da79"",
                        ""username"": ""aieem1"",
                        ""email"": ""aie@teste.com.br"",
                        ""firstName"": ""Aluno AIE EM 1"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""3E047757-A057-458E-87E7-6DFB8B49C3C3"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 614015,
                    ""dependent"": {
                        ""id"": 4665462,
                        ""keycloakId"": ""2752ffbc-4367-491a-86ee-a4ce2fe7406a"",
                        ""username"": ""alunolive160123"",
                        ""email"": null,
                        ""firstName"": ""Aluno Live 16-01-23"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""D8CA4CB3-BFE8-4EA9-8906-F584C5E27869"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                },
                {
                    ""id"": 626709,
                    ""dependent"": {
                        ""id"": 4960840,
                        ""keycloakId"": ""5b86dbb1-bb9b-453e-9661-f4caf835fa15"",
                        ""username"": ""sergiom"",
                        ""email"": ""prof.h.araken@prof.educacao.sp.gov.br"",
                        ""firstName"": ""Sergio Manoel"",
                        ""lastName"": null,
                        ""displayName"": null,
                        ""ownerBusinessUnit"": ""eem"",
                        ""cpf"": null,
                        ""rg"": null,
                        ""cellPhone"": null,
                        ""phone"": null,
                        ""birthday"": null,
                        ""inheritedId"": ""ECFA0407-4A0C-48DF-B97A-60E28894EDC7"",
                        ""businessUnit"": {
                            ""id"": 2,
                            ""name"": ""Escola em Movimento"",
                            ""code"": ""EEM"",
                            ""partnerIntegrationKeys"": [
                                {
                                    ""id"": 1,
                                    ""destinyBusinessUnit"": ""studos"",
                                    ""accessKey"": ""48771fd3-40bb-59f4-42bc-2141d75c89f5""
                                }
                            ],
                            ""realmName"": ""eem"",
                            ""businessUnitType"": {
                                ""id"": 1,
                                ""name"": ""CORE"",
                                ""description"": ""CORE""
                            }
                        },
                        ""accounts"": null
                    }
                }
            ]
        }
    ]
}

";


var result = JsonSerializer.Deserialize<UserInfoResponse>(json);

var classrooms = result.ToNiveisEnsino("21694ec0-88be-4231-ac2a-392dbf835518", "Professor");
*/

Console.WriteLine("");
Console.WriteLine("Pressione qualquer tecla...");
Console.ReadKey();