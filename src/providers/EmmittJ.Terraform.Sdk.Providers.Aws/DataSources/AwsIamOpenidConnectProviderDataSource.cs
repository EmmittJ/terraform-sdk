using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_openid_connect_provider.
/// </summary>
public class AwsIamOpenidConnectProviderDataSource : TerraformDataSource
{
    public AwsIamOpenidConnectProviderDataSource(string name) : base("aws_iam_openid_connect_provider", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Url { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    [TerraformPropertyName("client_id_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ClientIdList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "client_id_list");

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ThumbprintList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "thumbprint_list");

}
