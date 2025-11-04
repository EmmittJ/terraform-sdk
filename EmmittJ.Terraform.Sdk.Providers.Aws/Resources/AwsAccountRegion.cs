using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_account_region resource.
/// </summary>
public class AwsAccountRegion : TerraformResource
{
    public AwsAccountRegion(string name) : base("aws_account_region", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("opt_status");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("account_id")?.Value;
        set => WithPropertyInternal("account_id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("enabled")?.Value;
        set => WithPropertyInternal("enabled", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    public string? RegionName
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("region_name")?.Value;
        set => WithPropertyInternal("region_name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The opt_status attribute.
    /// </summary>
    public TerraformExpression OptStatus => this["opt_status"];

}
