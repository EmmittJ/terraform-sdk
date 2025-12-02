// Licensed under the MIT License.

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Defines well-known pipeline step tags used to categorize Terraform pipeline steps.
/// These tags enable other code to hook into Terraform steps after the fact.
/// </summary>
public static class TerraformPipelineTags
{
    /// <summary>
    /// Tag for steps that publish Terraform configuration files.
    /// </summary>
    public const string PublishTerraform = "publish-terraform";

    /// <summary>
    /// Tag for steps that run terraform init.
    /// </summary>
    public const string TerraformInit = "terraform-init";

    /// <summary>
    /// Tag for steps that run terraform plan.
    /// </summary>
    public const string TerraformPlan = "terraform-plan";

    /// <summary>
    /// Tag for steps that run terraform apply.
    /// </summary>
    public const string TerraformApply = "terraform-apply";

    /// <summary>
    /// Tag for steps that read terraform outputs.
    /// </summary>
    public const string TerraformOutputs = "terraform-outputs";

    /// <summary>
    /// Tag for steps related to container registry operations.
    /// </summary>
    public const string Registry = "registry";

    /// <summary>
    /// Tag for summary/output display steps.
    /// </summary>
    public const string TerraformSummary = "terraform-summary";
}
