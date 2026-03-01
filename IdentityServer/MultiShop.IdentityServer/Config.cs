using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityServer4;

namespace MultiShop.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceCatalog"){Scopes = {"CatalogFullPermisssion","CatalogReadPermission"}},
            new ApiResource("ResourceDiscount"){Scopes = {"DiscountFullPermisssion"}},
            new ApiResource("ResourceOrder"){Scopes = {"OrderFullPermisssion"}},
            new ApiResource("ResourceCargo"){Scopes = {"CargoFullPermisssion"}},
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermisssion", "Full authority for catalog operations"),
            new ApiScope("CatalogReadPermission", "Reading authority for catalog operations "),
            new ApiScope("DiscountFullPermisssion", "Reading authority for discount operations "),
            new ApiScope("OrderFullPermisssion", "Reading authority for order operations "),
            new ApiScope("CargoFullPermisssion", "Reading authority for cargo operations "),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            //Visitor
            new Client
            {
                ClientId = "MultiShopVisitorId",
                ClientName = "MultiShop Visitor User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("multishopsecret".Sha256()) },
                AllowedScopes = { "CatalogReadPermission" }
            },
            
            //Manager
            new Client
            {
                ClientId = "MultiShopManagerId",
                ClientName = "MultiShop Manager User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("multishopsecret".Sha256()) },
                AllowedScopes = { "CatalogReadPermission", "CatalogFullPermisssion" }
            },
            
            //Admin
            new Client
            {
                ClientId = "MultiShopAdminId",
                ClientName = "MultiShop Admin User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("multishopsecret".Sha256()) },
                AllowedScopes =
                {
                    "CatalogReadPermission", "CatalogFullPermisssion","DiscountFullPermisssion","OrderFullPermisssion","CargoFullPermisssion",
                    IdentityServerConstants.LocalApi.ScopeName,
                    IdentityServerConstants.StandardScopes.OpenId,  
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                },
                AccessTokenLifetime = 600
            }
        };
    }
}