using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_inspector2_enabler resource.
/// </summary>
public class AwsInspector2Enabler : TerraformResource
{
    public AwsInspector2Enabler(string name) : base("aws_inspector2_enabler", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    public HashSet<string>? AccountIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("account_ids")?.Value;
        set => this.WithProperty("account_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public HashSet<string>? ResourceTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_types")?.Value;
        set => this.WithProperty("resource_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
