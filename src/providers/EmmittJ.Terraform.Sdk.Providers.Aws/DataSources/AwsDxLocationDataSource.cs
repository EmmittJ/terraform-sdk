using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_location Terraform data source.
/// Retrieves information about a aws_dx_location.
/// </summary>
public partial class AwsDxLocationDataSource(string name) : TerraformDataSource("aws_dx_location", name)
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
    /// The location_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationCode is required")]
    public required TerraformValue<string> LocationCode
    {
        get => new TerraformReference<string>(this, "location_code");
        set => SetArgument("location_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The available_macsec_port_speeds attribute.
    /// </summary>
    public TerraformList<string> AvailableMacsecPortSpeeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_macsec_port_speeds").ResolveNodes(ctx));
    }

    /// <summary>
    /// The available_port_speeds attribute.
    /// </summary>
    public TerraformList<string> AvailablePortSpeeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_port_speeds").ResolveNodes(ctx));
    }

    /// <summary>
    /// The available_providers attribute.
    /// </summary>
    public TerraformList<string> AvailableProviders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_providers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    public TerraformValue<string> LocationName
    {
        get => new TerraformReference<string>(this, "location_name");
    }

}
