using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_aws_versions Terraform data source.
/// Retrieves information about a google_container_aws_versions.
/// </summary>
public partial class GoogleContainerAwsVersionsDataSource(string name) : TerraformDataSource("google_container_aws_versions", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public TerraformList<string> SupportedRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_regions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    public TerraformList<string> ValidVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "valid_versions").ResolveNodes(ctx));
    }

}
