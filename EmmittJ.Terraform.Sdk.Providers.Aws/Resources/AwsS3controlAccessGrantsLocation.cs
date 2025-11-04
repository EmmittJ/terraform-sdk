using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_location resource.
/// </summary>
public class AwsS3controlAccessGrantsLocation : TerraformResource
{
    public AwsS3controlAccessGrantsLocation(string name) : base("aws_s3control_access_grants_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_grants_location_arn");
        this.DeclareOutput("access_grants_location_id");
        this.DeclareOutput("id");
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
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location_scope attribute.
    /// </summary>
    public string? LocationScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_scope")?.Value;
        set => this.WithProperty("location_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The access_grants_location_arn attribute.
    /// </summary>
    public TerraformExpression AccessGrantsLocationArn => this["access_grants_location_arn"];

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    public TerraformExpression AccessGrantsLocationId => this["access_grants_location_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
