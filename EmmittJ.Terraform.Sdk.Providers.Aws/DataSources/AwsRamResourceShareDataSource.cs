using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ram_resource_share.
/// </summary>
public class AwsRamResourceShareDataSource : TerraformDataSource
{
    public AwsRamResourceShareDataSource(string name) : base("aws_ram_resource_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owning_account_id");
        this.DeclareOutput("resource_arns");
        this.DeclareOutput("status");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public string? ResourceOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner")?.Value;
        set => this.WithProperty("resource_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_share_status attribute.
    /// </summary>
    public string? ResourceShareStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_share_status")?.Value;
        set => this.WithProperty("resource_share_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owning_account_id attribute.
    /// </summary>
    public TerraformExpression OwningAccountId => this["owning_account_id"];

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public TerraformExpression ResourceArns => this["resource_arns"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
