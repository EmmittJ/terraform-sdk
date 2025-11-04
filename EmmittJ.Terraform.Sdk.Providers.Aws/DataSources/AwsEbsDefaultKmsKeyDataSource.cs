using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ebs_default_kms_key.
/// </summary>
public class AwsEbsDefaultKmsKeyDataSource : TerraformDataSource
{
    public AwsEbsDefaultKmsKeyDataSource(string name) : base("aws_ebs_default_kms_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key_arn");
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
    /// The key_arn attribute.
    /// </summary>
    public TerraformExpression KeyArn => this["key_arn"];

}
