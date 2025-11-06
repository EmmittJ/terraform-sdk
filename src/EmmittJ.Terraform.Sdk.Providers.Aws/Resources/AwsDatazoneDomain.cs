using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_domain resource.
/// </summary>
public class AwsDatazoneDomain : TerraformResource
{
    public AwsDatazoneDomain(string name) : base("aws_datazone_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("portal_url");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_execution_role attribute.
    /// </summary>
    public string? DomainExecutionRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_execution_role")?.Value;
        set => this.WithProperty("domain_execution_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_version attribute.
    /// </summary>
    public string? DomainVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_version")?.Value;
        set => this.WithProperty("domain_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public string? KmsKeyIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_identifier")?.Value;
        set => this.WithProperty("kms_key_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public string? ServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role")?.Value;
        set => this.WithProperty("service_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_deletion_check attribute.
    /// </summary>
    public bool? SkipDeletionCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_deletion_check")?.Value;
        set => this.WithProperty("skip_deletion_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformExpression PortalUrl => this["portal_url"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
