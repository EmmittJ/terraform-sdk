using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ce_cost_allocation_tag resource.
/// </summary>
public class AwsCeCostAllocationTag : TerraformResource
{
    public AwsCeCostAllocationTag(string name) : base("aws_ce_cost_allocation_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformProperty<string>? TagKey
    {
        get => GetProperty<TerraformProperty<string>>("tag_key");
        set => this.WithProperty("tag_key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
