using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_grants_location_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The s3_sub_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? S3SubPrefix
    {
        get => GetProperty<TerraformProperty<string>>("s3_sub_prefix");
        set => WithProperty("s3_sub_prefix", value);
    }

}

/// <summary>
/// Block type for grantee in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantGranteeBlock : TerraformBlock
{
    /// <summary>
    /// The grantee_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeIdentifier is required")]
    public required TerraformProperty<string> GranteeIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("grantee_identifier");
        set => WithProperty("grantee_identifier", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeType is required")]
    public required TerraformProperty<string> GranteeType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("grantee_type");
        set => WithProperty("grantee_type", value);
    }

}

/// <summary>
/// Manages a aws_s3control_access_grant resource.
/// </summary>
public class AwsS3controlAccessGrant : TerraformResource
{
    public AwsS3controlAccessGrant(string name) : base("aws_s3control_access_grant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_grant_arn");
        this.DeclareOutput("access_grant_id");
        this.DeclareOutput("grant_scope");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessGrantsLocationId is required")]
    public required TerraformProperty<string> AccessGrantsLocationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access_grants_location_id");
        set => this.WithProperty("access_grants_location_id", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformProperty<string> Permission
    {
        get => GetRequiredProperty<TerraformProperty<string>>("permission");
        set => this.WithProperty("permission", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The s3_prefix_type attribute.
    /// </summary>
    public TerraformProperty<string>? S3PrefixType
    {
        get => GetProperty<TerraformProperty<string>>("s3_prefix_type");
        set => this.WithProperty("s3_prefix_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for access_grants_location_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>? AccessGrantsLocationConfiguration
    {
        get => GetProperty<List<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>>("access_grants_location_configuration");
        set => this.WithProperty("access_grants_location_configuration", value);
    }

    /// <summary>
    /// Block for grantee.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3controlAccessGrantGranteeBlock>? Grantee
    {
        get => GetProperty<List<AwsS3controlAccessGrantGranteeBlock>>("grantee");
        set => this.WithProperty("grantee", value);
    }

    /// <summary>
    /// The access_grant_arn attribute.
    /// </summary>
    public TerraformExpression AccessGrantArn => this["access_grant_arn"];

    /// <summary>
    /// The access_grant_id attribute.
    /// </summary>
    public TerraformExpression AccessGrantId => this["access_grant_id"];

    /// <summary>
    /// The grant_scope attribute.
    /// </summary>
    public TerraformExpression GrantScope => this["grant_scope"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
