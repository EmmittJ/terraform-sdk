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
    public TerraformProperty<string>? ApplicationDomain
    {
        get => GetProperty<TerraformProperty<string>>("application_domain");
        set => this.WithProperty("application_domain", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public TerraformProperty<string>? AttachmentType
    {
        get => GetProperty<TerraformProperty<string>>("attachment_type");
        set => this.WithProperty("attachment_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("domain_certificate_arn");
        set => this.WithProperty("domain_certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointDomainPrefix
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_domain_prefix");
        set => this.WithProperty("endpoint_domain_prefix", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
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
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The verified_access_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? VerifiedAccessGroupId
    {
        get => GetProperty<TerraformProperty<string>>("verified_access_group_id");
        set => this.WithProperty("verified_access_group_id", value);
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
