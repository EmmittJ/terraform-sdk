using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_saml_provider Terraform data source.
/// Retrieves information about a aws_iam_saml_provider.
/// </summary>
public partial class AwsIamSamlProviderDataSource(string name) : TerraformDataSource("aws_iam_saml_provider", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
    {
        get => new TerraformReference<string>(this, "create_date");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The saml_metadata_document attribute.
    /// </summary>
    public TerraformValue<string> SamlMetadataDocument
    {
        get => new TerraformReference<string>(this, "saml_metadata_document");
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformValue<string> ValidUntil
    {
        get => new TerraformReference<string>(this, "valid_until");
    }

}
