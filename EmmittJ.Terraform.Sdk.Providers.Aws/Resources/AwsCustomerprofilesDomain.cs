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
    public string? DeadLetterQueueUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dead_letter_queue_url")?.Value;
        set => this.WithProperty("dead_letter_queue_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    public string? DefaultEncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_encryption_key")?.Value;
        set => this.WithProperty("default_encryption_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    public double? DefaultExpirationDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_expiration_days")?.Value;
        set => this.WithProperty("default_expiration_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
