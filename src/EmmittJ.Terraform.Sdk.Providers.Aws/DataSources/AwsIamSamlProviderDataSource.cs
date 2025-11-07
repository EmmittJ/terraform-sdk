using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_saml_provider.
/// </summary>
public class AwsIamSamlProviderDataSource : TerraformDataSource
{
    public AwsIamSamlProviderDataSource(string name) : base("aws_iam_saml_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_date");
        this.DeclareOutput("name");
        this.DeclareOutput("saml_metadata_document");
        this.DeclareOutput("valid_until");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The saml_metadata_document attribute.
    /// </summary>
    public TerraformExpression SamlMetadataDocument => this["saml_metadata_document"];

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformExpression ValidUntil => this["valid_until"];

}
