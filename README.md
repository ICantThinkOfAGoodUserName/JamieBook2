WebApi2Book
===========

This repository contains the example source code that accompanies *ASP.NET Web API 2: Building a REST Service from Start to Finish* (ISBN-13: 978-1484201107).

The book is available from Amazon: [http://www.amazon.com/gp/product/1484201108/ref=s9_simh_gw_p14_d4_i1?pf_rd_m=ATVPDKIKX0DER&pf_rd_s=center-2&pf_rd_r=1C2SG78VC0S7WHHJBKMA&pf_rd_t=101&pf_rd_p=1688200382&pf_rd_i=507846](http://www.amazon.com/gp/product/1484201108/ref=s9_simh_gw_p14_d4_i1?pf_rd_m=ATVPDKIKX0DER&pf_rd_s=center-2&pf_rd_r=1C2SG78VC0S7WHHJBKMA&pf_rd_t=101&pf_rd_p=1688200382&pf_rd_i=507846 "ASP.NET Web API 2 on Amazon").

The repository contains chapter-specific branches so that you can follow along with the implementation described in the book. The "completed" branch contains the finished solution, including the ASMX-based service and client discussed in Chapter 8. 

## Demo: Using Web API to Process SOAP Messages ##
1. Make sure the following sites are running in iisexpress: `WebApi2Book.Web.Api` and `WebApi2Book.Web.Legacy.Api`.
2. Start the `WebApi2Book.Windows.Legacy.Client` application.
3. Use the application to invoke methods against the legacy SOAP-based service and against the Web.API REST service.

If you examine the client application code you'll notice that the same proxy class is being used for both services (see the `MainWindow.GetServiceClient` method). The only difference is the endpoint being used for the particular service.
