using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dns_record_set Terraform data source.
/// Retrieves information about a google_dns_record_set.
/// </summary>
public partial class GoogleDnsRecordSetDataSource(string name) : TerraformDataSource("google_dns_record_set", name)
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
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformValue<string> ManagedZone
    {
        get => new TerraformReference<string>(this, "managed_zone");
        set => SetArgument("managed_zone", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The rrdatas attribute.
    /// </summary>
    public TerraformList<string> Rrdatas
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rrdatas").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
    }

}
