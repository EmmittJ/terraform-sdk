using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Provider-specific functions extension for aws.
/// </summary>
public static partial class Tf
{
    /// <summary>
    /// AWS provider-specific functions.
    /// </summary>
    public static class Aws
    {
        /// <summary>
        /// AWS provider functions.
        /// </summary>
        public static class Functions
        {
            /// <summary>
            /// arn_build Function
            ///
            /// Builds an ARN from its constituent parts
            /// </summary>
            /// <param name="partition">Partition in which the resource is located</param>
            /// <param name="service">Service namespace</param>
            /// <param name="region">Region code</param>
            /// <param name="accountId">AWS account identifier</param>
            /// <param name="resource">Resource section, typically composed of a resource type and identifier</param>
            public static TerraformExpression ArnBuild(TerraformExpression partition, TerraformExpression service, TerraformExpression region, TerraformExpression accountId, TerraformExpression resource)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::aws::arn_build",
                    partition, service, region, accountId, resource
                );
            }

            /// <summary>
            /// arn_parse Function
            ///
            /// Parses an ARN into its constituent parts
            /// </summary>
            /// <param name="arn">ARN (Amazon Resource Name) to parse</param>
            public static TerraformExpression ArnParse(TerraformExpression arn)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::aws::arn_parse",
                    arn
                );
            }

            /// <summary>
            /// trim_iam_role_path Function
            ///
            /// Trims the path prefix from an IAM role Amazon Resource Name (ARN). This function can be used when services require role ARNs to be passed without a path.
            /// </summary>
            /// <param name="arn">IAM role Amazon Resource Name (ARN)</param>
            public static TerraformExpression TrimIamRolePath(TerraformExpression arn)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::aws::trim_iam_role_path",
                    arn
                );
            }

        }
    }
}
