using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_domain_configuration resource.
/// </summary>
public class AwsIotDomainConfiguration : TerraformResource
{
    public AwsIotDomainConfiguration(string name) : base("aws_iot_domain_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_type");
    }

    /// <summary>
    /// The application_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_protocol");
        set => this.WithProperty("application_protocol", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The server_certificate_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ServerCertificateArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("server_certificate_arns");
        set => this.WithProperty("server_certificate_arns", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_type");
        set => this.WithProperty("service_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The validation_certificate_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValidationCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validation_certificate_arn");
        set => this.WithProperty("validation_certificate_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    public TerraformExpression DomainType => this["domain_type"];

}
