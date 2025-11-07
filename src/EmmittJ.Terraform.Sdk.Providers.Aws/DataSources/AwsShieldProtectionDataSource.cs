using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_shield_protection.
/// </summary>
public class AwsShieldProtectionDataSource : TerraformDataSource
{
    public AwsShieldProtectionDataSource(string name) : base("aws_shield_protection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("name");
        this.DeclareOutput("protection_arn");
    }

    /// <summary>
    /// The protection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProtectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protection_id");
        set => this.WithProperty("protection_id", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The protection_arn attribute.
    /// </summary>
    public TerraformExpression ProtectionArn => this["protection_arn"];

}
