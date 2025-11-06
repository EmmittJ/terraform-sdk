using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_endpoint resource.
/// </summary>
public class AwsVerifiedaccessEndpoint : TerraformResource
{
    public AwsVerifiedaccessEndpoint(string name) : base("aws_verifiedaccess_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("device_validation_domain");
        this.DeclareOutput("endpoint_domain");
        this.DeclareOutput("verified_access_instance_id");
    }

    /// <summary>
    /// The application_domain attribute.
    /// </summary>
    public string? ApplicationDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_domain")?.Value;
        set => this.WithProperty("application_domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public string? AttachmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attachment_type")?.Value;
        set => this.WithProperty("attachment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The domain_certificate_arn attribute.
    /// </summary>
    public string? DomainCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_certificate_arn")?.Value;
        set => this.WithProperty("domain_certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    public string? EndpointDomainPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_domain_prefix")?.Value;
        set => this.WithProperty("endpoint_domain_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public string? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type")?.Value;
        set => this.WithProperty("endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The verified_access_group_id attribute.
    /// </summary>
    public string? VerifiedAccessGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("verified_access_group_id")?.Value;
        set => this.WithProperty("verified_access_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_validation_domain attribute.
    /// </summary>
    public TerraformExpression DeviceValidationDomain => this["device_validation_domain"];

    /// <summary>
    /// The endpoint_domain attribute.
    /// </summary>
    public TerraformExpression EndpointDomain => this["endpoint_domain"];

    /// <summary>
    /// The verified_access_instance_id attribute.
    /// </summary>
    public TerraformExpression VerifiedAccessInstanceId => this["verified_access_instance_id"];

}
