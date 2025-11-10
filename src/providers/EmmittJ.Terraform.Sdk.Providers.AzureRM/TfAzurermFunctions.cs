using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Provider-specific functions extension for azurerm.
/// </summary>
public static partial class Tf
{
    /// <summary>
    /// AZURERM provider-specific functions.
    /// </summary>
    public static class Azurerm
    {
        /// <summary>
        /// AZURERM provider functions.
        /// </summary>
        public static class Functions
        {
            /// <summary>
            /// normalise_resource_id
            ///
            /// Parses and attempts to normalise the casing on an Azure Resource Manager ID into the correct casing for Terraform
            /// </summary>
            /// <param name="id">Resource ID</param>
            public static TerraformExpression NormaliseResourceId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::azurerm::normalise_resource_id",
                    id
                );
            }

            /// <summary>
            /// parse_resource_id
            ///
            /// Parses an Azure Resource Manager ID and exposes the contained information
            /// </summary>
            /// <param name="id">Resource ID</param>
            public static TerraformExpression ParseResourceId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::azurerm::parse_resource_id",
                    id
                );
            }

        }
    }
}
