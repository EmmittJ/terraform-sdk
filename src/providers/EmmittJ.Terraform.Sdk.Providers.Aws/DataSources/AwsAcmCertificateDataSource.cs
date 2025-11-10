using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acm_certificate.
/// </summary>
public class AwsAcmCertificateDataSource : TerraformDataSource
{
    public AwsAcmCertificateDataSource(string name) : base("aws_acm_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate");
        SetOutput("certificate_chain");
        SetOutput("status");
        SetOutput("domain");
        SetOutput("id");
        SetOutput("key_types");
        SetOutput("most_recent");
        SetOutput("region");
        SetOutput("statuses");
        SetOutput("tags");
        SetOutput("types");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> KeyTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("key_types");
        set => SetProperty("key_types", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool> MostRecent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("most_recent");
        set => SetProperty("most_recent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    public List<TerraformProperty<string>> Statuses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("statuses");
        set => SetProperty("statuses", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    public List<TerraformProperty<string>> Types
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("types");
        set => SetProperty("types", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
