using EmmittJ.Terraform.Sdk;

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
        this.DeclareOutput("opt_status");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RegionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region_name");
        set => this.WithProperty("region_name", value);
    }

    /// <summary>
    /// The opt_status attribute.
    /// </summary>
    public TerraformExpression OptStatus => this["opt_status"];

}
