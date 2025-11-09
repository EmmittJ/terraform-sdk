using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_customerprofiles_domain resource.
/// </summary>
public class AwsCustomerprofilesDomain : TerraformResource
{
    public AwsCustomerprofilesDomain(string name) : base("aws_customerprofiles_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The dead_letter_queue_url attribute.
    /// </summary>
    public TerraformProperty<string>? DeadLetterQueueUrl
    {
        get => GetProperty<TerraformProperty<string>>("dead_letter_queue_url");
        set => this.WithProperty("dead_letter_queue_url", value);
    }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultEncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("default_encryption_key");
        set => this.WithProperty("default_encryption_key", value);
    }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultExpirationDays
    {
        get => GetProperty<TerraformProperty<double>>("default_expiration_days");
        set => this.WithProperty("default_expiration_days", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
