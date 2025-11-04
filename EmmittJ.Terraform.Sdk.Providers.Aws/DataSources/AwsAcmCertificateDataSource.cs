using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        DeclareOutput("arn");
        DeclareOutput("certificate");
        DeclareOutput("certificate_chain");
        DeclareOutput("status");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("domain")?.Value;
        set => WithPropertyInternal("domain", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The key_types attribute.
    /// </summary>
    public HashSet&lt;string&gt;? KeyTypes
    {
        get => GetProperty<TerraformLiteralProperty&lt;HashSet&lt;string&gt;&gt;>("key_types")?.Value;
        set => WithPropertyInternal("key_types", value == null ? null : new TerraformLiteralProperty&lt;HashSet&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("most_recent")?.Value;
        set => WithPropertyInternal("most_recent", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    public List&lt;string&gt;? Statuses
    {
        get => GetProperty<TerraformLiteralProperty&lt;List&lt;string&gt;&gt;>("statuses")?.Value;
        set => WithPropertyInternal("statuses", value == null ? null : new TerraformLiteralProperty&lt;List&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    public List&lt;string&gt;? Types
    {
        get => GetProperty<TerraformLiteralProperty&lt;List&lt;string&gt;&gt;>("types")?.Value;
        set => WithPropertyInternal("types", value == null ? null : new TerraformLiteralProperty&lt;List&lt;string&gt;&gt;(value));
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
