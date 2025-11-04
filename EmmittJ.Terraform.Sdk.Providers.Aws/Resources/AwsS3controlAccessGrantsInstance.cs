using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_instance resource.
/// </summary>
public class AwsS3controlAccessGrantsInstance : TerraformResource
{
    public AwsS3controlAccessGrantsInstance(string name) : base("aws_s3control_access_grants_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_grants_instance_arn");
        this.DeclareOutput("access_grants_instance_id");
        this.DeclareOutput("id");
        this.DeclareOutput("identity_center_application_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_center_arn attribute.
    /// </summary>
    public string? IdentityCenterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_center_arn")?.Value;
        set => this.WithProperty("identity_center_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The access_grants_instance_arn attribute.
    /// </summary>
    public TerraformExpression AccessGrantsInstanceArn => this["access_grants_instance_arn"];

    /// <summary>
    /// The access_grants_instance_id attribute.
    /// </summary>
    public TerraformExpression AccessGrantsInstanceId => this["access_grants_instance_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    public TerraformExpression IdentityCenterApplicationArn => this["identity_center_application_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
